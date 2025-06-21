namespace EmployeeCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createEmplMenuItem = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВСпискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортБДВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Отделы = new System.Windows.Forms.GroupBox();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new EmployeeCard.EmployeesDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKEmployeessDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addEmplBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editEmplBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteEmplBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.WordExportBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcelBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.fKEmplPersonalDataEmployeessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.citizenshipTxt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.birthdateTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.workExpDisplayTxt = new System.Windows.Forms.TextBox();
            this.workExpHiddenTxt = new System.Windows.Forms.TextBox();
            this.fKEmplWorkDataEmployeessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.Education = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.PostTxt = new System.Windows.Forms.TextBox();
            this.emplPersonalDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplWorkDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeessTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmployeessTableAdapter();
            this.departmentsTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.DepartmentsTableAdapter();
            this.emplPersonalDataTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmplPersonalDataTableAdapter();
            this.emplWorkDataTableAdapter = new EmployeeCard.EmployeesDBDataSetTableAdapters.EmplWorkDataTableAdapter();
            this.emplPersonalDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exportToWordFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.exportToExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportToExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exporttoExcelDataSet = new EmployeeCard.exporttoExcelDataSet();
            this.createEmplMenuItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Отделы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeessDepartmentsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplPersonalDataEmployeessBindingSource)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDataEmployeessBindingSource)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplWorkDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exporttoExcelDataSet)).BeginInit();
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
            this.createEmplMenuItem.Size = new System.Drawing.Size(1445, 30);
            this.createEmplMenuItem.TabIndex = 0;
            this.createEmplMenuItem.Text = "menuStrip1";
            this.createEmplMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.createEmplMenuItem_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтделToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(14, 26);
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // создатьОтделToolStripMenuItem
            // 
            this.создатьОтделToolStripMenuItem.Name = "создатьОтделToolStripMenuItem";
            this.создатьОтделToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.создатьОтделToolStripMenuItem.Text = "Создать отдел";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            // 
            // управлениеДаннымиToolStripMenuItem
            // 
            this.управлениеДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделыToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem1,
            this.экспортБДВExcelToolStripMenuItem});
            this.управлениеДаннымиToolStripMenuItem.Name = "управлениеДаннымиToolStripMenuItem";
            this.управлениеДаннымиToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.управлениеДаннымиToolStripMenuItem.Text = "Управление данными";
            // 
            // отделыToolStripMenuItem1
            // 
            this.отделыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьВСпискеToolStripMenuItem});
            this.отделыToolStripMenuItem1.Name = "отделыToolStripMenuItem1";
            this.отделыToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.отделыToolStripMenuItem1.Text = "Отделы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьВСпискеToolStripMenuItem
            // 
            this.удалитьВСпискеToolStripMenuItem.Name = "удалитьВСпискеToolStripMenuItem";
            this.удалитьВСпискеToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.удалитьВСпискеToolStripMenuItem.Text = "Удалить в списке";
            this.удалитьВСпискеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВСпискеToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // экспортБДВExcelToolStripMenuItem
            // 
            this.экспортБДВExcelToolStripMenuItem.Name = "экспортБДВExcelToolStripMenuItem";
            this.экспортБДВExcelToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.экспортБДВExcelToolStripMenuItem.Text = "Экспорт БД в Excel";
            this.экспортБДВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортБДВExcelToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1445, 864);
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 856);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Отделы
            // 
            this.Отделы.Controls.Add(this.departmentCB);
            this.Отделы.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Отделы.Location = new System.Drawing.Point(4, 4);
            this.Отделы.Margin = new System.Windows.Forms.Padding(4);
            this.Отделы.Name = "Отделы";
            this.Отделы.Padding = new System.Windows.Forms.Padding(4);
            this.Отделы.Size = new System.Drawing.Size(524, 42);
            this.Отделы.TabIndex = 0;
            this.Отделы.TabStop = false;
            this.Отделы.Text = "Отделы";
            this.Отделы.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // departmentCB
            // 
            this.departmentCB.DataSource = this.departmentsBindingSource;
            this.departmentCB.DisplayMember = "Title";
            this.departmentCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(4, 19);
            this.departmentCB.Margin = new System.Windows.Forms.Padding(4);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(516, 24);
            this.departmentCB.TabIndex = 0;
            this.departmentCB.ValueMember = "Id";
            this.departmentCB.SelectedIndexChanged += new System.EventHandler(this.DepartmentsCB_SelectedIndexChanged);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeesDBBindingSource;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(524, 748);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // employeeGV
            // 
            this.employeeGV.AllowUserToAddRows = false;
            this.employeeGV.AllowUserToDeleteRows = false;
            this.employeeGV.AutoGenerateColumns = false;
            this.employeeGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn});
            this.employeeGV.DataSource = this.fKEmployeessDepartmentsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGV.Location = new System.Drawing.Point(4, 19);
            this.employeeGV.Margin = new System.Windows.Forms.Padding(4);
            this.employeeGV.Name = "employeeGV";
            this.employeeGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeGV.RowHeadersVisible = false;
            this.employeeGV.RowHeadersWidth = 51;
            this.employeeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGV.Size = new System.Drawing.Size(516, 725);
            this.employeeGV.TabIndex = 0;
            this.employeeGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGV_CellContentClick);
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
            // fKEmployeessDepartmentsBindingSource
            // 
            this.fKEmployeessDepartmentsBindingSource.DataMember = "FK_Employeess_Departments";
            this.fKEmployeessDepartmentsBindingSource.DataSource = this.departmentsBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmplBtn,
            this.toolStripSeparator1,
            this.editEmplBtn,
            this.toolStripSeparator2,
            this.deleteEmplBtn,
            this.toolStripSeparator3,
            this.WordExportBtn,
            this.toolStripSeparator4,
            this.exportToExcelBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 806);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addEmplBtn
            // 
            this.addEmplBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEmplBtn.Image = ((System.Drawing.Image)(resources.GetObject("addEmplBtn.Image")));
            this.addEmplBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmplBtn.Name = "addEmplBtn";
            this.addEmplBtn.Size = new System.Drawing.Size(80, 28);
            this.addEmplBtn.Text = "Добавить";
            this.addEmplBtn.Click += new System.EventHandler(this.addEmplBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // editEmplBtn
            // 
            this.editEmplBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editEmplBtn.Image = ((System.Drawing.Image)(resources.GetObject("editEmplBtn.Image")));
            this.editEmplBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editEmplBtn.Name = "editEmplBtn";
            this.editEmplBtn.Size = new System.Drawing.Size(82, 28);
            this.editEmplBtn.Text = "Изменить";
            this.editEmplBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // deleteEmplBtn
            // 
            this.deleteEmplBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteEmplBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmplBtn.Image")));
            this.deleteEmplBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteEmplBtn.Name = "deleteEmplBtn";
            this.deleteEmplBtn.Size = new System.Drawing.Size(69, 28);
            this.deleteEmplBtn.Text = "Удалить";
            this.deleteEmplBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // WordExportBtn
            // 
            this.WordExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WordExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("WordExportBtn.Image")));
            this.WordExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WordExportBtn.Name = "WordExportBtn";
            this.WordExportBtn.Size = new System.Drawing.Size(121, 28);
            this.WordExportBtn.Text = "Экспорт в Word";
            this.WordExportBtn.Click += new System.EventHandler(this.WordExportBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportToExcelBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportToExcelBtn.Image")));
            this.exportToExcelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(119, 28);
            this.exportToExcelBtn.Text = "Экспорт в Excel";
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(543, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 858);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(893, 837);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 412);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Персональные данные";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(881, 391);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Address);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(875, 235);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Адрес регистрации";
            // 
            // Address
            // 
            this.Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDataEmployeessBindingSource, "Address", true));
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Enabled = false;
            this.Address.Location = new System.Drawing.Point(3, 18);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(869, 214);
            this.Address.TabIndex = 0;
            this.Address.Text = "";
            // 
            // fKEmplPersonalDataEmployeessBindingSource
            // 
            this.fKEmplPersonalDataEmployeessBindingSource.DataMember = "FK_EmplPersonalData_Employeess";
            this.fKEmplPersonalDataEmployeessBindingSource.DataSource = this.fKEmployeessDepartmentsBindingSource;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ImageBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(875, 144);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(719, 138);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.citizenshipTxt);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 95);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(713, 40);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Гражданство";
            // 
            // citizenshipTxt
            // 
            this.citizenshipTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDataEmployeessBindingSource, "Citizenship", true));
            this.citizenshipTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.citizenshipTxt.Enabled = false;
            this.citizenshipTxt.Location = new System.Drawing.Point(3, 18);
            this.citizenshipTxt.Name = "citizenshipTxt";
            this.citizenshipTxt.Size = new System.Drawing.Size(707, 22);
            this.citizenshipTxt.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.birthdateTxt);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(713, 40);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата рождения";
            // 
            // birthdateTxt
            // 
            this.birthdateTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDataEmployeessBindingSource, "BirthDate", true));
            this.birthdateTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthdateTxt.Enabled = false;
            this.birthdateTxt.Location = new System.Drawing.Point(3, 18);
            this.birthdateTxt.Name = "birthdateTxt";
            this.birthdateTxt.Size = new System.Drawing.Size(707, 22);
            this.birthdateTxt.TabIndex = 0;
            this.birthdateTxt.TextChanged += new System.EventHandler(this.birthdateTxt_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ageTxt);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(713, 40);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Возраст";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // ageTxt
            // 
            this.ageTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDataEmployeessBindingSource, "Age", true));
            this.ageTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTxt.Enabled = false;
            this.ageTxt.Location = new System.Drawing.Point(3, 18);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(707, 22);
            this.ageTxt.TabIndex = 0;
            // 
            // ImageBox
            // 
            this.ImageBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fKEmplPersonalDataEmployeessBindingSource, "Photo", true));
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBox.Location = new System.Drawing.Point(3, 3);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(144, 138);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(887, 413);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рабочие данные";
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(881, 392);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.workExpDisplayTxt);
            this.groupBox11.Controls.Add(this.workExpHiddenTxt);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 345);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(875, 44);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Опыт работы";
            this.groupBox11.Enter += new System.EventHandler(this.groupBox11_Enter);
            // 
            // workExpDisplayTxt
            // 
            this.workExpDisplayTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workExpDisplayTxt.Location = new System.Drawing.Point(3, 18);
            this.workExpDisplayTxt.Name = "workExpDisplayTxt";
            this.workExpDisplayTxt.Size = new System.Drawing.Size(869, 22);
            this.workExpDisplayTxt.TabIndex = 1;
            this.workExpDisplayTxt.TextChanged += new System.EventHandler(this.workExpDisplayTxt_TextChanged);
            // 
            // workExpHiddenTxt
            // 
            this.workExpHiddenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeessBindingSource, "WorkExperience", true));
            this.workExpHiddenTxt.Enabled = false;
            this.workExpHiddenTxt.Location = new System.Drawing.Point(3, 18);
            this.workExpHiddenTxt.Name = "workExpHiddenTxt";
            this.workExpHiddenTxt.Size = new System.Drawing.Size(0, 22);
            this.workExpHiddenTxt.TabIndex = 0;
            this.workExpHiddenTxt.TextChanged += new System.EventHandler(this.workExpHiddenTxt_TextChanged);
            // 
            // fKEmplWorkDataEmployeessBindingSource
            // 
            this.fKEmplWorkDataEmployeessBindingSource.DataMember = "FK_EmplWorkData_Employeess";
            this.fKEmplWorkDataEmployeessBindingSource.DataSource = this.fKEmployeessDepartmentsBindingSource;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Education);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 53);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(875, 286);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Образование";
            // 
            // Education
            // 
            this.Education.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeessBindingSource, "Education", true));
            this.Education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Education.Location = new System.Drawing.Point(3, 18);
            this.Education.Name = "Education";
            this.Education.Size = new System.Drawing.Size(869, 265);
            this.Education.TabIndex = 0;
            this.Education.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PostTxt);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(875, 44);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Должность";
            // 
            // PostTxt
            // 
            this.PostTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeessBindingSource, "Post", true));
            this.PostTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostTxt.Enabled = false;
            this.PostTxt.Location = new System.Drawing.Point(3, 18);
            this.PostTxt.Name = "PostTxt";
            this.PostTxt.Size = new System.Drawing.Size(869, 22);
            this.PostTxt.TabIndex = 0;
            // 
            // emplPersonalDataBindingSource
            // 
            this.emplPersonalDataBindingSource.DataMember = "EmplPersonalData";
            this.emplPersonalDataBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // emplWorkDataBindingSource
            // 
            this.emplWorkDataBindingSource.DataMember = "EmplWorkData";
            this.emplWorkDataBindingSource.DataSource = this.employeesDBBindingSource;
            // 
            // employeessBindingSource1
            // 
            this.employeessBindingSource1.DataMember = "Employeess";
            this.employeessBindingSource1.DataSource = this.employeesDBBindingSource;
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
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // emplPersonalDataTableAdapter
            // 
            this.emplPersonalDataTableAdapter.ClearBeforeFill = true;
            // 
            // emplWorkDataTableAdapter
            // 
            this.emplWorkDataTableAdapter.ClearBeforeFill = true;
            // 
            // emplPersonalDataBindingSource1
            // 
            this.emplPersonalDataBindingSource1.DataMember = "EmplPersonalData";
            this.emplPersonalDataBindingSource1.DataSource = this.employeesDBDataSet;
            // 
            // exportToWordFileDialog
            // 
            this.exportToWordFileDialog.Filter = "Word files | *.docx";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fKEmplPersonalDataEmployeessBindingSource;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.fKEmplWorkDataEmployeessBindingSource;
            // 
            // exportToExcelDialog
            // 
            this.exportToExcelDialog.Filter = "Excel files | *.xlsx";
            // 
            // exportToExcelBindingSource
            // 
            this.exportToExcelBindingSource.DataSource = this.exporttoExcelDataSet;
            this.exportToExcelBindingSource.Position = 0;
            this.exportToExcelBindingSource.CurrentChanged += new System.EventHandler(this.exportToExcelBindingSource_CurrentChanged);
            // 
            // exporttoExcelDataSet
            // 
            this.exporttoExcelDataSet.DataSetName = "exporttoExcelDataSet";
            this.exporttoExcelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 894);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.createEmplMenuItem);
            this.MainMenuStrip = this.createEmplMenuItem;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeessDepartmentsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplPersonalDataEmployeessBindingSource)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDataEmployeessBindingSource)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplWorkDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplPersonalDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exporttoExcelDataSet)).EndInit();
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
        private System.Windows.Forms.ComboBox departmentCB;
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
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox citizenshipTxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox birthdateTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox workExpHiddenTxt;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox Education;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox PostTxt;
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
        private System.Windows.Forms.ToolStripButton addEmplBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editEmplBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteEmplBtn;
        private System.Windows.Forms.BindingSource emplPersonalDataBindingSource;
        private EmployeesDBDataSetTableAdapters.EmplPersonalDataTableAdapter emplPersonalDataTableAdapter;
        private System.Windows.Forms.BindingSource emplWorkDataBindingSource;
        private EmployeesDBDataSetTableAdapters.EmplWorkDataTableAdapter emplWorkDataTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem удалитьВСпискеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox workExpDisplayTxt;
        private System.Windows.Forms.BindingSource fKEmployeessDepartmentsBindingSource;
        private System.Windows.Forms.BindingSource emplPersonalDataBindingSource1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton WordExportBtn;
        private System.Windows.Forms.SaveFileDialog exportToWordFileDialog;
        private System.Windows.Forms.BindingSource fKEmplPersonalDataEmployeessBindingSource;
        private System.Windows.Forms.BindingSource fKEmplWorkDataEmployeessBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ToolStripMenuItem экспортБДВExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportToExcelDialog;
        private System.Windows.Forms.BindingSource exportToExcelBindingSource;
        private exporttoExcelDataSet exporttoExcelDataSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton exportToExcelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.PictureBox ImageBox;
    }
}

