using EmployeeCard.EmployeesDBDataSetTableAdapters;
using EmployeeCard.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCard
{
    public partial class DeleteDepForm : Form
    {
        public DeleteDepForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void RefreshData()
        {
            this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
        }
        private void DeleteDepForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.Departments". При необходимости она может быть перемещена или удалена.
            RefreshData();

        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Вы действительно хотите удалить выбранную запись?","Удалить запись",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(departmentCB.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry("Departments",id);
                RefreshData();
            }
        }
    }
}
