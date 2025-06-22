using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using EmployeeCard.EmployeesDBDataSetTableAdapters;
using EmployeeCard.exporttoExcelDataSetTableAdapters;
using EmployeeCard.Models;
using EmployeeCard.Utils;
using ExelExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTemplateFiller;
using WordTemplateFiller.Models;

namespace EmployeeCard
{

    public partial class MainForm : Form
    {
        private const string templatesFolderName = "Templates";
        private const string templateFileName = "Card.docx";
        private string templatePath;

        private const int lastNameColumnIdx = 2;
        private const int firstNameColumnIdx = 3;
        private const int patronimicColumnIdx = 4;

        public MainForm()
        {
            InitializeComponent();
            var currentAssemblyPath = Assembly.GetExecutingAssembly().Location;
            var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
            templatePath = $"D:\\DB_APP\\EmployeeCard\\{templatesFolderName}\\{templateFileName}";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
                Address.ReadOnly = true;
                Education.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ageTxt.DataBindings.Add(employeeGV.);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EditDepartmentForm().ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует выбранный отдел");
                    return;
                }
                var id = 0;

                if (int.TryParse(departmentCB.SelectedValue.ToString(), out id) && new EditDepartmentForm(true, 1).ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void RefreshData()
        {

            this.emplWorkDataTableAdapter.Fill(this.employeesDBDataSet.EmplWorkData);
            this.emplPersonalDataTableAdapter.Fill(this.employeesDBDataSet.EmplPersonalData);
            this.employeessTableAdapter.Fill(this.employeesDBDataSet.Employeess);
            this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует выбранный отдел");
                    return;
                }
                var id = 0;

                if (int.TryParse(departmentCB.SelectedValue.ToString(), out id)
                    && MessageBox.Show($"Вы действительно хотите удалить выбранный отдел ({departmentCB.Text})?",
                    "Удалить выбранный отдел", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.DepartmentsTableName, id);
                    this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DepartmentsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void удалитьВСпискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DeleteDepForm().ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void DeleteEmployee()
        {
            if (employeeGV.Rows.Count == 0 || employeeGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран ни один сотрудник!");
                return;
            }

            var id = 0;
            int.TryParse(employeeGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);

            var firstName = employeeGV.SelectedRows[0].Cells[3].Value?.ToString() ?? string.Empty;
            var lastName = employeeGV.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;
            var middleName = employeeGV.SelectedRows[0].Cells[4].Value?.ToString() ?? string.Empty;
            var fio = $"{lastName} {firstName} {middleName}";

            if (id != 0
                && MessageBox.Show($"Вы действительно хотите удалить сотрудника {fio}?",
                "Удаление сотрудника", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBHelper.DeleteEntry(Constants.TableNames.EmployeesTableName, id);
                this.employeessTableAdapter.Fill(this.employeesDBDataSet.Employeess);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//deleteBtn
            => DeleteEmployee();

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
            => DeleteEmployee();

        private void RefreshEmployees()
        {
            this.emplWorkDataTableAdapter.Fill(this.employeesDBDataSet.EmplWorkData);
            this.emplPersonalDataTableAdapter.Fill(this.employeesDBDataSet.EmplPersonalData);
            this.employeessTableAdapter.Fill(this.employeesDBDataSet.Employeess);
        }

        private void EditEmployee(bool isEditMode = false)
        {
            try
            {
                if (isEditMode)
                {
                    if (employeeGV.Rows.Count == 0 || employeeGV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Не выбран ни один сотрудник!");
                        return;
                    }
                    var id = 0;
                    int.TryParse(employeeGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);

                    if (id != 0 && new EditEmployeeForm(true, id).ShowDialog() == DialogResult.OK)
                    {
                        RefreshEmployees();
                    }

                }
                else if (new EditEmployeeForm().ShowDialog() == DialogResult.OK)
                {
                    RefreshEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }



        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        => EditEmployee(true);
        private void toolStripButton2_Click(object sender, EventArgs e)//edit employee
        => EditEmployee(true);

        private void addEmplBtn_Click(object sender, EventArgs e)
        => EditEmployee();

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        => EditEmployee();

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
         => Application.Exit();

        private void workExpDisplayTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void workExpHiddenTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var parsedDate = DateTime.Now;
                if (DateTime.TryParse(((TextBox)sender).Text, out parsedDate))
                {
                    var diff = DateTime.Now - parsedDate;
                    var totalDays = diff.TotalDays;

                    var years = Math.Floor(totalDays / 365);
                    var months = Math.Floor((totalDays - years * 365) / 30);
                    var days = Math.Floor(totalDays - years * 365 - months * 30);

                    workExpDisplayTxt.Text =
                        $"Лет: {years}, месяцев: {months}, дней: {days}";
                }
                else
                {
                    workExpDisplayTxt.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                workExpDisplayTxt.Clear();
                MessageBox.Show(ex.ToString());
            }
        }

        private void createEmplMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void WordExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeGV.Rows.Count == 0)
                {
                    MessageBox.Show("Список сотрудников пуст");
                    return;
                }

                if (exportToWordFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = exportToWordFileDialog.FileName;

                    var employeeGVSelectedRow = employeeGV.SelectedRows[0];
                    var fio = $"{employeeGVSelectedRow.Cells[lastNameColumnIdx].Value} {employeeGVSelectedRow.Cells[firstNameColumnIdx].Value} {employeeGVSelectedRow.Cells[patronimicColumnIdx].Value}";


                    var bmList = new List<BookMark>
                {
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "FIO",
                        BookMarkValue = fio
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "CITIZENSHIP",
                        BookMarkValue = citizenshipTxt.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "DATE",
                        BookMarkValue = birthdateTxt.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "AGE",
                        BookMarkValue = ageTxt.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "",
                        BookMarkValue = ""
                    },//??????????
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "POST",
                        BookMarkValue = PostTxt.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "OTDEL",
                        BookMarkValue = departmentCB.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "WORKYEARS",
                        BookMarkValue = workExpDisplayTxt.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "ADDRESS",
                        BookMarkValue = Address.Text
                    },
                    new BookMark {
                        BookMarkType = BookMarkType.Text,
                        BookMarkName = "EDUCATION",
                        BookMarkValue = Education.Text
                    }

                };
                    new DocumentManager(templatePath, bmList).saveDocument(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void экспортБДВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (exportToExcelDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelDialog.FileName;
                    new ExcelExportManager().ExportDataSet(employeesDBDataSet, filePath);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportToExcelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (exportToExcelDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelDialog.FileName;

                    var departmentId = 0;
                    int.TryParse(departmentCB.SelectedValue.ToString(), out departmentId);

                    var exportTableAdapter = new ExportToExcelTableAdapter();
                    exportTableAdapter.Fill(exporttoExcelDataSet.Employeess, departmentId);

                    new ExcelExportManager().ExportDataSet(exporttoExcelDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void birthdateTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var currentFolder = "D:\\DB_APP\\EmployeeCard";
            try
            {
                var imageName = ((TextBox)sender).Text;
                ImageBox.ImageLocation
                    = !string.IsNullOrEmpty(imageName)
                    ? $"{currentFolder}\\ImgData\\{imageName}"
                    : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openCardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var currentFolder = "D:\\DB_APP\\EmployeeCard";
                if (!string.IsNullOrEmpty(CardField.Text))
                {
                    var path = $"{currentFolder}\\CardsData\\{CardField.Text}.docx";
                    Process.Start(new ProcessStartInfo(path));
                }
            } catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void excelImportBtn_Click(object sender, EventArgs e)
        {
            var departmentId = 0;
            if (int.TryParse(departmentCB.SelectedValue.ToString(), out departmentId))
            {
                if (excelImportFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var data = new List<List<string>>();

                    using (var fs = new FileStream(excelImportFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (var doc = SpreadsheetDocument.Open(fs, false))
                        {
                            var workbookPart = doc.WorkbookPart;
                            var worksheetPart = workbookPart.WorksheetParts
                                .FirstOrDefault(wsp => wsp.Uri.OriginalString.IndexOf("sheet1") != -1);
                            var sheetData = worksheetPart?.Worksheet.Elements<SheetData>().FirstOrDefault();

                            foreach (var row in sheetData.Elements<Row>())
                            {
                                var rowData = new List<string>();
                                foreach (var cell in row.Elements<Cell>())
                                {
                                    var value = cell.InnerText;
                                    if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                                    {
                                        var index = int.Parse(value);
                                        value = workbookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(index).InnerText;
                                    }
                                    rowData.Add(value);
                                }
                                data.Add(rowData);
                            }
                        }
                    }

                    foreach (var dataRow in data)
                    {
                        AddEmployeeHelper.Add(new EmployeeDto
                        {
                            Address = dataRow[Constants.FieldsName.ExcelCells.J],
                            Age = dataRow[Constants.FieldsName.ExcelCells.D],
                            BirthDate = dataRow[Constants.FieldsName.ExcelCells.E],
                            Citizenship = dataRow[Constants.FieldsName.ExcelCells.H],
                            DepartmentId = departmentId.ToString(),
                            Education = dataRow[Constants.FieldsName.ExcelCells.I],
                            EmployeeId = string.Empty,
                            FirstName = dataRow[Constants.FieldsName.ExcelCells.B],
                            LastName = dataRow[Constants.FieldsName.ExcelCells.A],
                            MiddleName = dataRow[Constants.FieldsName.ExcelCells.C],
                            Post = dataRow[Constants.FieldsName.ExcelCells.F],
                            WorkExperience = dataRow[Constants.FieldsName.ExcelCells.G]
                        });
                    }
                    RefreshData();

                }
            }
            else
            {
                MessageBox.Show("Не удалось получить идентификатор!");
            }
        }
    }
}
