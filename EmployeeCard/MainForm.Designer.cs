﻿namespace EmployeeCard
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createEmplMenuItem = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Отделы = new System.Windows.Forms.GroupBox();
            this.DepartmentsCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeGV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeesDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new EmployeeCard.EmployeesDBDataSet();
            this.employeessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeessTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmployeessTableAdapter();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Education = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.управлениеДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emplPersonalDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplPersonalDataTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmplPersonalDataTableAdapter();
            this.emplWorkDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplWorkDataTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmplWorkDataTableAdapter();
            this.createEmplMenuItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Отделы.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplWorkDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createEmplMenuItem
            // 
            this.createEmplMenuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.createEmplMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отделыToolStripMenuItem,
            this.управлениеДаннымиToolStripMenuItem});
            this.createEmplMenuItem.Location = new System.Drawing.Point(0, 0);
            this.createEmplMenuItem.Name = "createEmplMenuItem";
            this.createEmplMenuItem.Size = new System.Drawing.Size(1445, 28);
            this.createEmplMenuItem.TabIndex = 0;
            this.createEmplMenuItem.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтделToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // создатьОтделToolStripMenuItem
            // 
            this.создатьОтделToolStripMenuItem.Name = "создатьОтделToolStripMenuItem";
            this.создатьОтделToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьОтделToolStripMenuItem.Text = "Создать отдел";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1445, 866);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Отделы, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 858);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Отделы
            // 
            this.Отделы.Controls.Add(this.DepartmentsCB);
            this.Отделы.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Отделы.Location = new System.Drawing.Point(4, 4);
            this.Отделы.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Отделы.Name = "Отделы";
            this.Отделы.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Отделы.Size = new System.Drawing.Size(451, 42);
            this.Отделы.TabIndex = 0;
            this.Отделы.TabStop = false;
            this.Отделы.Text = "Отделы";
            this.Отделы.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DepartmentsCB
            // 
            this.DepartmentsCB.DataSource = this.departmentsBindingSource;
            this.DepartmentsCB.DisplayMember = "Title";
            this.DepartmentsCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsCB.FormattingEnabled = true;
            this.DepartmentsCB.Location = new System.Drawing.Point(4, 19);
            this.DepartmentsCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartmentsCB.Name = "DepartmentsCB";
            this.DepartmentsCB.Size = new System.Drawing.Size(443, 24);
            this.DepartmentsCB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(451, 750);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники:";
            // 
            // employeeGV
            // 
            this.employeeGV.AllowUserToAddRows = false;
            this.employeeGV.AllowUserToDeleteRows = false;
            this.employeeGV.AutoGenerateColumns = false;
            this.employeeGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn});
            this.employeeGV.DataSource = this.employeessBindingSource1;
            this.employeeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGV.Location = new System.Drawing.Point(4, 19);
            this.employeeGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeGV.Name = "employeeGV";
            this.employeeGV.ReadOnly = true;
            this.employeeGV.RowHeadersVisible = false;
            this.employeeGV.RowHeadersWidth = 51;
            this.employeeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGV.Size = new System.Drawing.Size(443, 727);
            this.employeeGV.TabIndex = 0;
            // 
            // employeesDBBindingSource
            // 
            this.employeesDBBindingSource.DataSource = this.employeesDBDataSet;
            this.employeesDBBindingSource.Position = 0;
            // 
            // employeesDBDataSet
            // 
            this.employeesDBDataSet.DataSetName = "EmployeesDBDataSet";
            this.employeesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeessBindingSource
            // 
            this.employeessBindingSource.DataMember = "Employeess";
            this.employeessBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // employeessTableAdapter
            // 
            this.employeessTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeessBindingSource1
            // 
            this.employeessBindingSource1.DataMember = "Employeess";
            this.employeessBindingSource1.DataSource = this.employeesDBBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(470, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 860);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о сотруднике";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(966, 839);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 413);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Персональные данные";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 414);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рабочие данные";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(954, 392);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(948, 44);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Возраст";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplPersonalDataBindingSource, "Age", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(942, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(948, 44);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата рождения";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplPersonalDataBindingSource, "BirthDate", true));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(942, 22);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 103);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(948, 44);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Гражданство";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplPersonalDataBindingSource, "Citizenship", true));
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(942, 22);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Address);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(948, 236);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Адрес регистрации";
            // 
            // Address
            // 
            this.Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplPersonalDataBindingSource, "Address", true));
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Enabled = false;
            this.Address.Location = new System.Drawing.Point(3, 18);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(942, 215);
            this.Address.TabIndex = 0;
            this.Address.Text = "";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.groupBox10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(954, 393);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(948, 44);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Должность";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplWorkDataBindingSource, "Post", true));
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(942, 22);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Education);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 53);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(948, 287);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Образование";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 346);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(948, 44);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Опыт работы";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplWorkDataBindingSource, "WorkExperience", true));
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(3, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(942, 22);
            this.textBox6.TabIndex = 0;
            // 
            // Education
            // 
            this.Education.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplWorkDataBindingSource, "Education", true));
            this.Education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Education.Location = new System.Drawing.Point(3, 18);
            this.Education.Name = "Education";
            this.Education.Size = new System.Drawing.Size(942, 266);
            this.Education.TabIndex = 0;
            this.Education.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 808);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 24);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 24);
            this.toolStripButton2.Text = "Изменить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(69, 24);
            this.toolStripButton3.Text = "Удалить";
            // 
            // управлениеДаннымиToolStripMenuItem
            // 
            this.управлениеДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделыToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem1});
            this.управлениеДаннымиToolStripMenuItem.Name = "управлениеДаннымиToolStripMenuItem";
            this.управлениеДаннымиToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.управлениеДаннымиToolStripMenuItem.Text = "Управление данными";
            // 
            // отделыToolStripMenuItem1
            // 
            this.отделыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.отделыToolStripMenuItem1.Name = "отделыToolStripMenuItem1";
            this.отделыToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.отделыToolStripMenuItem1.Text = "Отделы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // emplPersonalDataBindingSource
            // 
            this.emplPersonalDataBindingSource.DataMember = "EmplPersonalData";
            this.emplPersonalDataBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // emplPersonalDataTableAdapter
            // 
            this.emplPersonalDataTableAdapter.ClearBeforeFill = true;
            // 
            // emplWorkDataBindingSource
            // 
            this.emplWorkDataBindingSource.DataMember = "EmplWorkData";
            this.emplWorkDataBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // emplWorkDataTableAdapter
            // 
            this.emplWorkDataTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 894);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.createEmplMenuItem);
            this.MainMenuStrip = this.createEmplMenuItem;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1463, 941);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка сотрудника";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.createEmplMenuItem.ResumeLayout(false);
            this.createEmplMenuItem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Отделы.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplWorkDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip createEmplMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОтделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox Отделы;
        private System.Windows.Forms.ComboBox DepartmentsCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView employeeGV;
        private System.Windows.Forms.BindingSource employeesDBBindingSource;
        private EmployeesDBDataSet employeesDBDataSet;
        private System.Windows.Forms.BindingSource employeessBindingSource;
        private EmployeesDBDataSetTableAdapters.EmployeessTableAdapter employeessTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource employeessBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox Education;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem управлениеДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource emplPersonalDataBindingSource;
        private EmployeesDBDataSetTableAdapters.EmplPersonalDataTableAdapter emplPersonalDataTableAdapter;
        private System.Windows.Forms.BindingSource emplWorkDataBindingSource;
        private EmployeesDBDataSetTableAdapters.EmplWorkDataTableAdapter emplWorkDataTableAdapter;
    }
}

