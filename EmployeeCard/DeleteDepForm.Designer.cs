namespace EmployeeCard
{
    partial class DeleteDepForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new EmployeeCard.EmployeesDBDataSet();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел:";
            // 
            // departmentCB
            // 
            this.departmentCB.DataSource = this.departmentsBindingSource;
            this.departmentCB.DisplayMember = "Title";
            this.departmentCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(0, 16);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(372, 24);
            this.departmentCB.TabIndex = 1;
            this.departmentCB.ValueMember = "Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeesDBDataSet;
            // 
            // employeesDBDataSet
            // 
            this.employeesDBDataSet.DataSetName = "EmployeesDBDataSet";
            this.employeesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteBtn.Location = new System.Drawing.Point(3, 63);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 25);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(189, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 98);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(390, 145);
            this.Name = "DeleteDepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить отдел";
            this.Load += new System.EventHandler(this.DeleteDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button2;
        private EmployeesDBDataSet employeesDBDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
    }
}