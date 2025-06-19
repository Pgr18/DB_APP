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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.EmplWorkData". При необходимости она может быть перемещена или удалена.
            this.emplWorkDataTableAdapter.Fill(this.employeesDBDataSet.EmplWorkData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.EmplPersonalData". При необходимости она может быть перемещена или удалена.
            this.emplPersonalDataTableAdapter.Fill(this.employeesDBDataSet.EmplPersonalData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.Employeess". При необходимости она может быть перемещена или удалена.
            this.employeessTableAdapter.Fill(this.employeesDBDataSet.Employeess);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employeesDBDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.Employeess". При необходимости она может быть перемещена или удалена.
            this.employeessTableAdapter.Fill(this.employeesDBDataSet.Employeess);
            Address.ReadOnly = true;
            Education.ReadOnly = true;  

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

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            if (new DeleteDepForm().ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }

        }

        private void DepartmentsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
