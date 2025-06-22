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
            AddEmployeeHelper.Add(new Models.EmployeeDto
            {
                Address = addressTxt.Text,
                Age = Math.Ceiling((DateTime.Now - dateTimebirth.Value).TotalDays / 365).ToString(),
                BirthDate = dateTimebirth.Value.ToString("dd.MM.yyyy"),
                CardPath = _cardPath,
                Citizenship = citizenTxt.Text,
                DepartmentId = departmentCB.SelectedValue.ToString(),
                Education = educationTxt.Text,
                EmployeeId = _id.ToString(),
                FirstName = firstNameTxt.Text,
                MiddleName = middleNameTxt.Text,
                LastName = lastNameTxt.Text,
                PhotoPath = _photoPath,
                Post = PostTxt.Text,
                WorkExperience = dateTimecareer.Value.ToString("dd.MM.yyyy")
            },_isEditMode);
            DialogResult = DialogResult.OK;
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

        private void chooseCardFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
