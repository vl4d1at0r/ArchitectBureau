namespace ArchitectBureau
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.ratings = new System.Windows.Forms.ToolStripMenuItem();
            this.generateContract = new System.Windows.Forms.ToolStripMenuItem();
            this.financeDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.projectPage = new System.Windows.Forms.TabPage();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.projectPanel = new System.Windows.Forms.Panel();
            this.projectDoneDate = new System.Windows.Forms.TextBox();
            this.projectStartDate = new System.Windows.Forms.TextBox();
            this.projectStatus = new System.Windows.Forms.ComboBox();
            this.projectTypeLabel = new System.Windows.Forms.Label();
            this.projectType = new System.Windows.Forms.ComboBox();
            this.projectCustomer = new System.Windows.Forms.ComboBox();
            this.projectCustomerLabel = new System.Windows.Forms.Label();
            this.projectStatusLabel = new System.Windows.Forms.Label();
            this.projectDoneDateLabel = new System.Windows.Forms.Label();
            this.projectStartDateLabel = new System.Windows.Forms.Label();
            this.projectTeam = new System.Windows.Forms.ComboBox();
            this.projectTeamLabel = new System.Windows.Forms.Label();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeeAcceptDate = new System.Windows.Forms.TextBox();
            this.employeeBirthDate = new System.Windows.Forms.TextBox();
            this.employeeAcceptDateLabel = new System.Windows.Forms.Label();
            this.employeePhone = new System.Windows.Forms.TextBox();
            this.employeePhoneLabel = new System.Windows.Forms.Label();
            this.employeeHomeAddress = new System.Windows.Forms.TextBox();
            this.employeeHomeAddressLabel = new System.Windows.Forms.Label();
            this.employeePosition = new System.Windows.Forms.ComboBox();
            this.employeePositionLabel = new System.Windows.Forms.Label();
            this.employeeTeam = new System.Windows.Forms.ComboBox();
            this.employeeTeamLabel = new System.Windows.Forms.Label();
            this.employeeBirthDateLabel = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.TextBox();
            this.employeeSurnameLabel = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerSurname = new System.Windows.Forms.TextBox();
            this.customerSurnameLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.projectPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItem,
            this.lateProjects,
            this.ratings,
            this.generateContract,
            this.financeDocumentation});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(71, 20);
            this.addItem.Text = "Добавить";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // lateProjects
            // 
            this.lateProjects.Name = "lateProjects";
            this.lateProjects.Size = new System.Drawing.Size(145, 20);
            this.lateProjects.Text = "Задержанные проекты";
            // 
            // ratings
            // 
            this.ratings.Name = "ratings";
            this.ratings.Size = new System.Drawing.Size(63, 20);
            this.ratings.Text = "Рейтинг";
            // 
            // generateContract
            // 
            this.generateContract.Name = "generateContract";
            this.generateContract.Size = new System.Drawing.Size(123, 20);
            this.generateContract.Text = "Составить договор";
            // 
            // financeDocumentation
            // 
            this.financeDocumentation.Name = "financeDocumentation";
            this.financeDocumentation.Size = new System.Drawing.Size(167, 20);
            this.financeDocumentation.Text = "Финансовая документация";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.projectPage);
            this.tabControl.Controls.Add(this.employeePage);
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Location = new System.Drawing.Point(170, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 19);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // projectPage
            // 
            this.projectPage.Location = new System.Drawing.Point(4, 22);
            this.projectPage.Name = "projectPage";
            this.projectPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectPage.Size = new System.Drawing.Size(992, 0);
            this.projectPage.TabIndex = 0;
            this.projectPage.Text = "Проекти";
            this.projectPage.UseVisualStyleBackColor = true;
            // 
            // employeePage
            // 
            this.employeePage.Location = new System.Drawing.Point(4, 22);
            this.employeePage.Name = "employeePage";
            this.employeePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeePage.Size = new System.Drawing.Size(992, 0);
            this.employeePage.TabIndex = 1;
            this.employeePage.Text = "Співробітники";
            this.employeePage.UseVisualStyleBackColor = true;
            // 
            // customerPage
            // 
            this.customerPage.Location = new System.Drawing.Point(4, 22);
            this.customerPage.Name = "customerPage";
            this.customerPage.Size = new System.Drawing.Size(992, 0);
            this.customerPage.TabIndex = 2;
            this.customerPage.Text = "Клиенты";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(0, 529);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(167, 41);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Применить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(56, 33);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(55, 13);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Фильтры";
            // 
            // projectPanel
            // 
            this.projectPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectPanel.Controls.Add(this.projectDoneDate);
            this.projectPanel.Controls.Add(this.projectStartDate);
            this.projectPanel.Controls.Add(this.projectStatus);
            this.projectPanel.Controls.Add(this.projectTypeLabel);
            this.projectPanel.Controls.Add(this.projectType);
            this.projectPanel.Controls.Add(this.projectCustomer);
            this.projectPanel.Controls.Add(this.projectCustomerLabel);
            this.projectPanel.Controls.Add(this.projectStatusLabel);
            this.projectPanel.Controls.Add(this.projectDoneDateLabel);
            this.projectPanel.Controls.Add(this.projectStartDateLabel);
            this.projectPanel.Controls.Add(this.projectTeam);
            this.projectPanel.Controls.Add(this.projectTeamLabel);
            this.projectPanel.Location = new System.Drawing.Point(0, 49);
            this.projectPanel.Name = "projectPanel";
            this.projectPanel.Size = new System.Drawing.Size(168, 474);
            this.projectPanel.TabIndex = 4;
            // 
            // projectDoneDate
            // 
            this.projectDoneDate.Location = new System.Drawing.Point(2, 102);
            this.projectDoneDate.Name = "projectDoneDate";
            this.projectDoneDate.Size = new System.Drawing.Size(158, 20);
            this.projectDoneDate.TabIndex = 30;
            // 
            // projectStartDate
            // 
            this.projectStartDate.Location = new System.Drawing.Point(2, 65);
            this.projectStartDate.Name = "projectStartDate";
            this.projectStartDate.Size = new System.Drawing.Size(158, 20);
            this.projectStartDate.TabIndex = 29;
            // 
            // projectStatus
            // 
            this.projectStatus.FormattingEnabled = true;
            this.projectStatus.Location = new System.Drawing.Point(3, 142);
            this.projectStatus.Name = "projectStatus";
            this.projectStatus.Size = new System.Drawing.Size(157, 21);
            this.projectStatus.TabIndex = 28;
            // 
            // projectTypeLabel
            // 
            this.projectTypeLabel.AutoSize = true;
            this.projectTypeLabel.Location = new System.Drawing.Point(2, 166);
            this.projectTypeLabel.Name = "projectTypeLabel";
            this.projectTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.projectTypeLabel.TabIndex = 27;
            this.projectTypeLabel.Text = "Тип проекта:";
            // 
            // projectType
            // 
            this.projectType.FormattingEnabled = true;
            this.projectType.Location = new System.Drawing.Point(3, 182);
            this.projectType.Name = "projectType";
            this.projectType.Size = new System.Drawing.Size(157, 21);
            this.projectType.TabIndex = 26;
            // 
            // projectCustomer
            // 
            this.projectCustomer.FormattingEnabled = true;
            this.projectCustomer.Location = new System.Drawing.Point(4, 219);
            this.projectCustomer.Name = "projectCustomer";
            this.projectCustomer.Size = new System.Drawing.Size(158, 21);
            this.projectCustomer.TabIndex = 14;
            // 
            // projectCustomerLabel
            // 
            this.projectCustomerLabel.AutoSize = true;
            this.projectCustomerLabel.Location = new System.Drawing.Point(3, 203);
            this.projectCustomerLabel.Name = "projectCustomerLabel";
            this.projectCustomerLabel.Size = new System.Drawing.Size(46, 13);
            this.projectCustomerLabel.TabIndex = 13;
            this.projectCustomerLabel.Text = "Клиент:";
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.AutoSize = true;
            this.projectStatusLabel.Location = new System.Drawing.Point(3, 125);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(44, 13);
            this.projectStatusLabel.TabIndex = 8;
            this.projectStatusLabel.Text = "Статус:";
            // 
            // projectDoneDateLabel
            // 
            this.projectDoneDateLabel.AutoSize = true;
            this.projectDoneDateLabel.Location = new System.Drawing.Point(2, 86);
            this.projectDoneDateLabel.Name = "projectDoneDateLabel";
            this.projectDoneDateLabel.Size = new System.Drawing.Size(101, 13);
            this.projectDoneDateLabel.TabIndex = 6;
            this.projectDoneDateLabel.Text = "Дата выполнения:";
            // 
            // projectStartDateLabel
            // 
            this.projectStartDateLabel.AutoSize = true;
            this.projectStartDateLabel.Location = new System.Drawing.Point(2, 47);
            this.projectStartDateLabel.Name = "projectStartDateLabel";
            this.projectStartDateLabel.Size = new System.Drawing.Size(75, 13);
            this.projectStartDateLabel.TabIndex = 5;
            this.projectStartDateLabel.Text = "Дата заказа:";
            // 
            // projectTeam
            // 
            this.projectTeam.FormattingEnabled = true;
            this.projectTeam.Location = new System.Drawing.Point(2, 23);
            this.projectTeam.Name = "projectTeam";
            this.projectTeam.Size = new System.Drawing.Size(158, 21);
            this.projectTeam.TabIndex = 3;
            // 
            // projectTeamLabel
            // 
            this.projectTeamLabel.AutoSize = true;
            this.projectTeamLabel.Location = new System.Drawing.Point(2, 7);
            this.projectTeamLabel.Name = "projectTeamLabel";
            this.projectTeamLabel.Size = new System.Drawing.Size(55, 13);
            this.projectTeamLabel.TabIndex = 2;
            this.projectTeamLabel.Text = "Команда:";
            // 
            // employeePanel
            // 
            this.employeePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeePanel.Controls.Add(this.employeeAcceptDate);
            this.employeePanel.Controls.Add(this.employeeBirthDate);
            this.employeePanel.Controls.Add(this.employeeAcceptDateLabel);
            this.employeePanel.Controls.Add(this.employeePhone);
            this.employeePanel.Controls.Add(this.employeePhoneLabel);
            this.employeePanel.Controls.Add(this.employeeHomeAddress);
            this.employeePanel.Controls.Add(this.employeeHomeAddressLabel);
            this.employeePanel.Controls.Add(this.employeePosition);
            this.employeePanel.Controls.Add(this.employeePositionLabel);
            this.employeePanel.Controls.Add(this.employeeTeam);
            this.employeePanel.Controls.Add(this.employeeTeamLabel);
            this.employeePanel.Controls.Add(this.employeeBirthDateLabel);
            this.employeePanel.Controls.Add(this.employeeSurname);
            this.employeePanel.Controls.Add(this.employeeSurnameLabel);
            this.employeePanel.Controls.Add(this.employeeName);
            this.employeePanel.Controls.Add(this.employeeNameLabel);
            this.employeePanel.Location = new System.Drawing.Point(0, 49);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(168, 474);
            this.employeePanel.TabIndex = 5;
            // 
            // employeeAcceptDate
            // 
            this.employeeAcceptDate.Location = new System.Drawing.Point(4, 285);
            this.employeeAcceptDate.Name = "employeeAcceptDate";
            this.employeeAcceptDate.Size = new System.Drawing.Size(158, 20);
            this.employeeAcceptDate.TabIndex = 22;
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.Location = new System.Drawing.Point(3, 73);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(158, 20);
            this.employeeBirthDate.TabIndex = 21;
            // 
            // employeeAcceptDateLabel
            // 
            this.employeeAcceptDateLabel.AutoSize = true;
            this.employeeAcceptDateLabel.Location = new System.Drawing.Point(0, 265);
            this.employeeAcceptDateLabel.Name = "employeeAcceptDateLabel";
            this.employeeAcceptDateLabel.Size = new System.Drawing.Size(77, 13);
            this.employeeAcceptDateLabel.TabIndex = 19;
            this.employeeAcceptDateLabel.Text = "Дата приёма:";
            // 
            // employeePhone
            // 
            this.employeePhone.Location = new System.Drawing.Point(4, 242);
            this.employeePhone.Name = "employeePhone";
            this.employeePhone.Size = new System.Drawing.Size(157, 20);
            this.employeePhone.TabIndex = 18;
            // 
            // employeePhoneLabel
            // 
            this.employeePhoneLabel.AutoSize = true;
            this.employeePhoneLabel.Location = new System.Drawing.Point(0, 225);
            this.employeePhoneLabel.Name = "employeePhoneLabel";
            this.employeePhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.employeePhoneLabel.TabIndex = 17;
            this.employeePhoneLabel.Text = "Телефон:";
            // 
            // employeeHomeAddress
            // 
            this.employeeHomeAddress.Location = new System.Drawing.Point(4, 202);
            this.employeeHomeAddress.Name = "employeeHomeAddress";
            this.employeeHomeAddress.Size = new System.Drawing.Size(157, 20);
            this.employeeHomeAddress.TabIndex = 16;
            // 
            // employeeHomeAddressLabel
            // 
            this.employeeHomeAddressLabel.AutoSize = true;
            this.employeeHomeAddressLabel.Location = new System.Drawing.Point(0, 185);
            this.employeeHomeAddressLabel.Name = "employeeHomeAddressLabel";
            this.employeeHomeAddressLabel.Size = new System.Drawing.Size(98, 13);
            this.employeeHomeAddressLabel.TabIndex = 15;
            this.employeeHomeAddressLabel.Text = "Домашня адреса:";
            // 
            // employeePosition
            // 
            this.employeePosition.FormattingEnabled = true;
            this.employeePosition.Location = new System.Drawing.Point(3, 158);
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.Size = new System.Drawing.Size(158, 21);
            this.employeePosition.TabIndex = 9;
            // 
            // employeePositionLabel
            // 
            this.employeePositionLabel.AutoSize = true;
            this.employeePositionLabel.Location = new System.Drawing.Point(0, 139);
            this.employeePositionLabel.Name = "employeePositionLabel";
            this.employeePositionLabel.Size = new System.Drawing.Size(68, 13);
            this.employeePositionLabel.TabIndex = 8;
            this.employeePositionLabel.Text = "Должность:";
            // 
            // employeeTeam
            // 
            this.employeeTeam.FormattingEnabled = true;
            this.employeeTeam.Location = new System.Drawing.Point(3, 114);
            this.employeeTeam.Name = "employeeTeam";
            this.employeeTeam.Size = new System.Drawing.Size(158, 21);
            this.employeeTeam.TabIndex = 7;
            // 
            // employeeTeamLabel
            // 
            this.employeeTeamLabel.AutoSize = true;
            this.employeeTeamLabel.Location = new System.Drawing.Point(0, 96);
            this.employeeTeamLabel.Name = "employeeTeamLabel";
            this.employeeTeamLabel.Size = new System.Drawing.Size(55, 13);
            this.employeeTeamLabel.TabIndex = 6;
            this.employeeTeamLabel.Text = "Команда:";
            // 
            // employeeBirthDateLabel
            // 
            this.employeeBirthDateLabel.AutoSize = true;
            this.employeeBirthDateLabel.Location = new System.Drawing.Point(0, 56);
            this.employeeBirthDateLabel.Name = "employeeBirthDateLabel";
            this.employeeBirthDateLabel.Size = new System.Drawing.Size(89, 13);
            this.employeeBirthDateLabel.TabIndex = 4;
            this.employeeBirthDateLabel.Text = "Дата рождения:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.Location = new System.Drawing.Point(59, 27);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(102, 20);
            this.employeeSurname.TabIndex = 3;
            // 
            // employeeSurnameLabel
            // 
            this.employeeSurnameLabel.AutoSize = true;
            this.employeeSurnameLabel.Location = new System.Drawing.Point(0, 30);
            this.employeeSurnameLabel.Name = "employeeSurnameLabel";
            this.employeeSurnameLabel.Size = new System.Drawing.Size(59, 13);
            this.employeeSurnameLabel.TabIndex = 2;
            this.employeeSurnameLabel.Text = "Фамилия:";
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(59, 4);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(102, 20);
            this.employeeName.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(0, 7);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(32, 13);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Имя:";
            // 
            // customerPanel
            // 
            this.customerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerPanel.Controls.Add(this.customerPhone);
            this.customerPanel.Controls.Add(this.customerPhoneLabel);
            this.customerPanel.Controls.Add(this.customerEmail);
            this.customerPanel.Controls.Add(this.customerEmailLabel);
            this.customerPanel.Controls.Add(this.customerSurname);
            this.customerPanel.Controls.Add(this.customerSurnameLabel);
            this.customerPanel.Controls.Add(this.customerName);
            this.customerPanel.Controls.Add(this.customerNameLabel);
            this.customerPanel.Location = new System.Drawing.Point(0, 49);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(168, 474);
            this.customerPanel.TabIndex = 6;
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(4, 146);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(157, 20);
            this.customerPhone.TabIndex = 7;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(4, 129);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.customerPhoneLabel.TabIndex = 6;
            this.customerPhoneLabel.Text = "Телефон:";
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(4, 102);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(157, 20);
            this.customerEmail.TabIndex = 5;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(4, 85);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(40, 13);
            this.customerEmailLabel.TabIndex = 4;
            this.customerEmailLabel.Text = "Почта:";
            // 
            // customerSurname
            // 
            this.customerSurname.Location = new System.Drawing.Point(4, 60);
            this.customerSurname.Name = "customerSurname";
            this.customerSurname.Size = new System.Drawing.Size(157, 20);
            this.customerSurname.TabIndex = 3;
            // 
            // customerSurnameLabel
            // 
            this.customerSurnameLabel.AutoSize = true;
            this.customerSurnameLabel.Location = new System.Drawing.Point(4, 43);
            this.customerSurnameLabel.Name = "customerSurnameLabel";
            this.customerSurnameLabel.Size = new System.Drawing.Size(59, 13);
            this.customerSurnameLabel.TabIndex = 2;
            this.customerSurnameLabel.Text = "Фамилия:";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(4, 21);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(157, 20);
            this.customerName.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(4, 4);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(32, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Имя:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(170, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(996, 521);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 573);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.projectPanel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.employeePanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Архитектурное бюро";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.projectPanel.ResumeLayout(false);
            this.projectPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage projectPage;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Panel projectPanel;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.ComboBox projectTeam;
        private System.Windows.Forms.Label projectTeamLabel;
        private System.Windows.Forms.Label projectStartDateLabel;
        private System.Windows.Forms.Label projectStatusLabel;
        private System.Windows.Forms.Label projectDoneDateLabel;
        private System.Windows.Forms.ComboBox projectCustomer;
        private System.Windows.Forms.Label projectCustomerLabel;
        private System.Windows.Forms.TextBox employeeSurname;
        private System.Windows.Forms.Label employeeSurnameLabel;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeBirthDateLabel;
        private System.Windows.Forms.ComboBox employeePosition;
        private System.Windows.Forms.Label employeePositionLabel;
        private System.Windows.Forms.ComboBox employeeTeam;
        private System.Windows.Forms.Label employeeTeamLabel;
        private System.Windows.Forms.TextBox employeeHomeAddress;
        private System.Windows.Forms.Label employeeHomeAddressLabel;
        private System.Windows.Forms.Label employeeAcceptDateLabel;
        private System.Windows.Forms.TextBox employeePhone;
        private System.Windows.Forms.Label employeePhoneLabel;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.TextBox customerSurname;
        private System.Windows.Forms.Label customerSurnameLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.ToolStripMenuItem lateProjects;
        private System.Windows.Forms.ToolStripMenuItem ratings;
        private System.Windows.Forms.ToolStripMenuItem generateContract;
        private System.Windows.Forms.ToolStripMenuItem financeDocumentation;
        private System.Windows.Forms.Label projectTypeLabel;
        private System.Windows.Forms.ComboBox projectType;
        private System.Windows.Forms.ComboBox projectStatus;
        private System.Windows.Forms.TextBox projectDoneDate;
        private System.Windows.Forms.TextBox projectStartDate;
        private System.Windows.Forms.TextBox employeeAcceptDate;
        private System.Windows.Forms.TextBox employeeBirthDate;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

