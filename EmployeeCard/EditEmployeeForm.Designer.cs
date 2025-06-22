namespace EmployeeCard
{
    partial class EditEmployeeForm
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
            this.persGB = new System.Windows.Forms.GroupBox();
            this.addressTxt = new System.Windows.Forms.RichTextBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editEmployeeDataSet = new EmployeeCard.EditEmployeeDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.citizenTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimebirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNamelbl = new System.Windows.Forms.Label();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.workGB = new System.Windows.Forms.GroupBox();
            this.dateTimecareer = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.educationTxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PostTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveEmplBtn = new System.Windows.Forms.Button();
            this.cancelEmplBtn = new System.Windows.Forms.Button();
            this.employeesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter();
            this.dataTable1TableAdapter = new EmployeeCard.EditEmployeeDataSetTableAdapters.DataTable1TableAdapter();
            this.choosePhotoBtn = new System.Windows.Forms.Button();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseCardBtn = new System.Windows.Forms.Button();
            this.chooseCardFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            this.persGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.workGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.departmentCB.Size = new System.Drawing.Size(832, 24);
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
            // persGB
            // 
            this.persGB.Controls.Add(this.addressTxt);
            this.persGB.Controls.Add(this.label5);
            this.persGB.Controls.Add(this.citizenTxt);
            this.persGB.Controls.Add(this.label4);
            this.persGB.Controls.Add(this.dateTimebirth);
            this.persGB.Controls.Add(this.label3);
            this.persGB.Controls.Add(this.middleNamelbl);
            this.persGB.Controls.Add(this.firstNamelbl);
            this.persGB.Controls.Add(this.middleNameTxt);
            this.persGB.Controls.Add(this.firstNameTxt);
            this.persGB.Controls.Add(this.lastNameTxt);
            this.persGB.Controls.Add(this.lastNamelbl);
            this.persGB.Location = new System.Drawing.Point(12, 46);
            this.persGB.Name = "persGB";
            this.persGB.Size = new System.Drawing.Size(378, 396);
            this.persGB.TabIndex = 2;
            this.persGB.TabStop = false;
            this.persGB.Text = "Персональные данные";
            this.persGB.Enter += new System.EventHandler(this.persGB_Enter);
            // 
            // addressTxt
            // 
            this.addressTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Address", true));
            this.addressTxt.Location = new System.Drawing.Point(7, 296);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(365, 94);
            this.addressTxt.TabIndex = 11;
            this.addressTxt.Text = "";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.editEmployeeDataSet;
            // 
            // editEmployeeDataSet
            // 
            this.editEmployeeDataSet.DataSetName = "EditEmployeeDataSet";
            this.editEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Адрес регистрации";
            // 
            // citizenTxt
            // 
            this.citizenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Citizenship", true));
            this.citizenTxt.Location = new System.Drawing.Point(6, 247);
            this.citizenTxt.Name = "citizenTxt";
            this.citizenTxt.Size = new System.Drawing.Size(369, 22);
            this.citizenTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Гражданство";
            // 
            // dateTimebirth
            // 
            this.dateTimebirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "BirthDate", true));
            this.dateTimebirth.Location = new System.Drawing.Point(6, 193);
            this.dateTimebirth.Name = "dateTimebirth";
            this.dateTimebirth.Size = new System.Drawing.Size(369, 22);
            this.dateTimebirth.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // middleNamelbl
            // 
            this.middleNamelbl.AutoSize = true;
            this.middleNamelbl.Location = new System.Drawing.Point(3, 125);
            this.middleNamelbl.Name = "middleNamelbl";
            this.middleNamelbl.Size = new System.Drawing.Size(70, 16);
            this.middleNamelbl.TabIndex = 5;
            this.middleNamelbl.Text = "Отчество";
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Location = new System.Drawing.Point(3, 68);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(33, 16);
            this.firstNamelbl.TabIndex = 4;
            this.firstNamelbl.Text = "Имя";
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource1, "MiddleName", true));
            this.middleNameTxt.Location = new System.Drawing.Point(6, 144);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(369, 22);
            this.middleNameTxt.TabIndex = 3;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.editEmployeeDataSet;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource1, "FirstName", true));
            this.firstNameTxt.Location = new System.Drawing.Point(6, 87);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(369, 22);
            this.firstNameTxt.TabIndex = 2;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "LastName", true));
            this.lastNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTxt.Location = new System.Drawing.Point(3, 34);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(372, 22);
            this.lastNameTxt.TabIndex = 1;
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastNamelbl.Location = new System.Drawing.Point(3, 18);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(66, 16);
            this.lastNamelbl.TabIndex = 0;
            this.lastNamelbl.Text = "Фамилия";
            this.lastNamelbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // workGB
            // 
            this.workGB.Controls.Add(this.dateTimecareer);
            this.workGB.Controls.Add(this.label8);
            this.workGB.Controls.Add(this.educationTxt);
            this.workGB.Controls.Add(this.label7);
            this.workGB.Controls.Add(this.PostTxt);
            this.workGB.Controls.Add(this.label6);
            this.workGB.Location = new System.Drawing.Point(396, 46);
            this.workGB.Name = "workGB";
            this.workGB.Size = new System.Drawing.Size(392, 396);
            this.workGB.TabIndex = 3;
            this.workGB.TabStop = false;
            this.workGB.Text = "Рабочие данные";
            // 
            // dateTimecareer
            // 
            this.dateTimecareer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "WorkExperience", true));
            this.dateTimecareer.Location = new System.Drawing.Point(6, 247);
            this.dateTimecareer.Name = "dateTimecareer";
            this.dateTimecareer.Size = new System.Drawing.Size(369, 22);
            this.dateTimecareer.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Дата начала карьеры";
            // 
            // educationTxt
            // 
            this.educationTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Education", true));
            this.educationTxt.Location = new System.Drawing.Point(6, 87);
            this.educationTxt.Name = "educationTxt";
            this.educationTxt.Size = new System.Drawing.Size(365, 128);
            this.educationTxt.TabIndex = 12;
            this.educationTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Образование";
            // 
            // PostTxt
            // 
            this.PostTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Post", true));
            this.PostTxt.Location = new System.Drawing.Point(7, 33);
            this.PostTxt.Name = "PostTxt";
            this.PostTxt.Size = new System.Drawing.Size(364, 22);
            this.PostTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отдел";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saveEmplBtn
            // 
            this.saveEmplBtn.Location = new System.Drawing.Point(19, 448);
            this.saveEmplBtn.Name = "saveEmplBtn";
            this.saveEmplBtn.Size = new System.Drawing.Size(141, 23);
            this.saveEmplBtn.TabIndex = 5;
            this.saveEmplBtn.Text = "Сохранить";
            this.saveEmplBtn.UseVisualStyleBackColor = true;
            this.saveEmplBtn.Click += new System.EventHandler(this.saveEmplBtn_Click);
            // 
            // cancelEmplBtn
            // 
            this.cancelEmplBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelEmplBtn.Location = new System.Drawing.Point(647, 448);
            this.cancelEmplBtn.Name = "cancelEmplBtn";
            this.cancelEmplBtn.Size = new System.Drawing.Size(141, 23);
            this.cancelEmplBtn.TabIndex = 6;
            this.cancelEmplBtn.Text = "Отмена";
            this.cancelEmplBtn.UseVisualStyleBackColor = true;
            // 
            // employeesDBDataSetBindingSource
            // 
            this.employeesDBDataSetBindingSource.DataSource = this.employeesDBDataSet;
            this.employeesDBDataSetBindingSource.Position = 0;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // choosePhotoBtn
            // 
            this.choosePhotoBtn.Location = new System.Drawing.Point(196, 448);
            this.choosePhotoBtn.Name = "choosePhotoBtn";
            this.choosePhotoBtn.Size = new System.Drawing.Size(191, 23);
            this.choosePhotoBtn.TabIndex = 7;
            this.choosePhotoBtn.Text = "Выбрать фотографию";
            this.choosePhotoBtn.UseVisualStyleBackColor = true;
            this.choosePhotoBtn.Click += new System.EventHandler(this.choosePhotoBtn_Click);
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.FileName = "openFileDialog1";
            // 
            // chooseCardBtn
            // 
            this.chooseCardBtn.Location = new System.Drawing.Point(402, 448);
            this.chooseCardBtn.Name = "chooseCardBtn";
            this.chooseCardBtn.Size = new System.Drawing.Size(212, 23);
            this.chooseCardBtn.TabIndex = 8;
            this.chooseCardBtn.Text = "Карточка сотрудника";
            this.chooseCardBtn.UseVisualStyleBackColor = true;
            this.chooseCardBtn.Click += new System.EventHandler(this.chooseCardBtn_Click);
            // 
            // chooseCardFileDialog
            // 
            this.chooseCardFileDialog.FileName = "openFileDialog1";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 483);
            this.Controls.Add(this.chooseCardBtn);
            this.Controls.Add(this.choosePhotoBtn);
            this.Controls.Add(this.cancelEmplBtn);
            this.Controls.Add(this.saveEmplBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workGB);
            this.Controls.Add(this.persGB);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            this.persGB.ResumeLayout(false);
            this.persGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.workGB.ResumeLayout(false);
            this.workGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.GroupBox persGB;
        private System.Windows.Forms.GroupBox workGB;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label middleNamelbl;
        private System.Windows.Forms.Label firstNamelbl;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.DateTimePicker dateTimebirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox citizenTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox addressTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PostTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox educationTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimecareer;
        private System.Windows.Forms.Button saveEmplBtn;
        private System.Windows.Forms.Button cancelEmplBtn;
        private System.Windows.Forms.BindingSource employeesDBDataSetBindingSource;
        private EmployeesDBDataSet employeesDBDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private EditEmployeeDataSet editEmployeeDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private EditEmployeeDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Button choosePhotoBtn;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.Button chooseCardBtn;
        private System.Windows.Forms.OpenFileDialog chooseCardFileDialog;
    }
}