using EmployeeCard.EditEmployeeDataSetTableAdapters;
using EmployeeCard.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmployeeCard.Utils.DBHelper;
using System.Reflection;

namespace EmployeeCard
{
    public partial class EditEmployeeForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;
        private byte[] _photo;
        private string _photoPath;
        private string _cardPath;
        private string currentFolder;


        public EditEmployeeForm()
        {
            InitializeComponent();
            currentFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public EditEmployeeForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();
        }   

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void persGB_Enter(object sender, EventArgs e)
        {

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
            if (_isEditMode)
            {
                this.dataTable1TableAdapter.Fill(this.editEmployeeDataSet.DataTable1, _id);
                var employeeData = this.dataTable1TableAdapter.GetData(_id);
                if (employeeData?.Count > 0)
                {
                    var departmentId = employeeData.FirstOrDefault()?.DepartmentId ?? 0;
                    departmentCB.SelectedValue = departmentId;
                }
                choosePhotoBtn.Visible = true;
                chooseCardBtn.Visible = false;

            }
            else
            {
                choosePhotoBtn.Visible = false ;
                chooseCardBtn.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveEmplBtn_Click(object sender, EventArgs e)
        {
            var employeeFields = new Dictionary<string, TableField>();
            employeeFields.Add(Constants.FieldsName.EmployeesTable.DepartmentId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = departmentCB.SelectedValue.ToString()
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.LastName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = lastNameTxt.Text
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.FirstName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = firstNameTxt.Text
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.MiddleName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = middleNameTxt.Text
            });

            var personalDataFields = new Dictionary<string, TableField>();
            var workDataFields = new Dictionary<string, TableField>();



            //Pers data


            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.EmployeeId, new TableField
            {
                TableFieldType= TableFieldTypes.integer,
                TableFieldValue = string.Empty
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Age, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = Math.Ceiling((DateTime.Now - dateTimebirth.Value).TotalDays / 365).ToString()
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.BirthDate, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dateTimebirth.Value.ToString("dd.MM.yyyy")
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Citizenship, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = citizenTxt.Text
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Address, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = addressTxt.Text
            });

            //work data

            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.EmployeeId , new TableField
            {
                TableFieldType= TableFieldTypes.integer,
                TableFieldValue = string.Empty
            });

            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Post, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = PostTxt.Text
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Education, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = educationTxt.Text
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkExperience, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dateTimecareer.Value.ToString("dd.MM.yyyy")
            });


            if (!string.IsNullOrEmpty(_cardPath))
            {
                var technicalCardName
                    = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_mm_ss_ms")}.docx";
                File.Copy(_cardPath, $"{currentFolder}\\CardsData\\{technicalCardName}",true);

                workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkCard, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = technicalCardName
                });
            }


            if (_isEditMode)
            {

                if (!string.IsNullOrEmpty(_photoPath))
                {

                    var currentFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var technicalFileName
                        = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_mm_ss_ms")}{Path.GetExtension(_photoPath)}";
                    File.Copy(_photoPath, $"{currentFolder}\\ImgData\\{technicalFileName}", true);
                    personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.PhotoFileName, new TableField
                    {
                        TableFieldType = TableFieldTypes.nvarchar,
                        TableFieldValue = _photoPath
                    });
                }

                personalDataFields[Constants.FieldsName.EmplPersonalDataTable.EmployeeId].TableFieldValue
                = _id.ToString();
                workDataFields[Constants.FieldsName.EmplWorkDataTable.EmployeeId].TableFieldValue
                    = _id.ToString();

                DBHelper.UpdateEntry(Constants.TableNames.EmployeesTableName, _id, employeeFields);
                DBHelper.UpdateEntry(Constants.TableNames.EmplPersonalDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplPersonalDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = _id.ToString()
                    }
                }, personalDataFields);
                DBHelper.UpdateEntry(Constants.TableNames.EmplWorkDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplWorkDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = _id.ToString()
                    }
                }, workDataFields);

/*                if (_photo != null)
                {
                    DBHelper.InsertPhoto(Constants.TableNames.EmployeesTableName, "Photo", _id, _photo);
                }*/


                DialogResult = DialogResult.OK;
            }
            else
            {
                var employeeId = DBHelper.InsertEntry(Constants.TableNames.EmployeesTableName, employeeFields);
                personalDataFields[Constants.FieldsName.EmplPersonalDataTable.EmployeeId].TableFieldValue 
                    = employeeId.ToString();
                workDataFields[Constants.FieldsName.EmplWorkDataTable.EmployeeId].TableFieldValue
                    = employeeId.ToString();

                DBHelper.InsertEntry(Constants.TableNames.EmplPersonalDataTableName, personalDataFields);
                DBHelper.InsertEntry(Constants.TableNames.EmplWorkDataTableName, workDataFields);
                DialogResult = DialogResult.OK; 
            }
        }

        private void choosePhotoBtn_Click(object sender, EventArgs e)
        {
            if (chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                //var path = chooseFileDialog.FileName;
                //_photo = File.ReadAllBytes(path);
                _photoPath = chooseFileDialog.FileName;
            }
        }

        private void chooseCardBtn_Click(object sender, EventArgs e)
        {
            if (chooseCardFileDialog.ShowDialog() == DialogResult.OK)
            {
                _cardPath = chooseCardFileDialog.FileName;
            }
        }
    }
}
