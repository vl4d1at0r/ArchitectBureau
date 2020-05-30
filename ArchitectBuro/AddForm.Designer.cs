namespace ArchitectBuro
{
    partial class AddForm
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
            this.createTypeLabel = new System.Windows.Forms.Label();
            this.createTypeComboBox = new System.Windows.Forms.ComboBox();
            this.projectPanel = new System.Windows.Forms.Panel();
            this.projectStatusComboBox = new System.Windows.Forms.ComboBox();
            this.projectOrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.projectCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.projectCustomerLabel = new System.Windows.Forms.Label();
            this.projectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.projectTypeLabel = new System.Windows.Forms.Label();
            this.projectStatusLabel = new System.Windows.Forms.Label();
            this.projectOrderDateLabel = new System.Windows.Forms.Label();
            this.projectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.projectTeamLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.employeePositionComboBox = new System.Windows.Forms.ComboBox();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeeApplyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeApplyDateLabel = new System.Windows.Forms.Label();
            this.employeePhoneTextBox = new System.Windows.Forms.TextBox();
            this.employeePhoneLabel = new System.Windows.Forms.Label();
            this.employeeHomeAddressTextBox = new System.Windows.Forms.TextBox();
            this.employeeHomeAddressLabel = new System.Windows.Forms.Label();
            this.employeeBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeBirthDateLabel = new System.Windows.Forms.Label();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameLabel = new System.Windows.Forms.Label();
            this.employeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeFirstNameLabel = new System.Windows.Forms.Label();
            this.employeePositionLabel = new System.Windows.Forms.Label();
            this.employeeTeamComboBox = new System.Windows.Forms.ComboBox();
            this.employeeTeamLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameLabel = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerFirstNameLabel = new System.Windows.Forms.Label();
            this.projectPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTypeLabel
            // 
            this.createTypeLabel.AutoSize = true;
            this.createTypeLabel.Location = new System.Drawing.Point(7, 24);
            this.createTypeLabel.Name = "createTypeLabel";
            this.createTypeLabel.Size = new System.Drawing.Size(29, 13);
            this.createTypeLabel.TabIndex = 0;
            this.createTypeLabel.Text = "Тип:";
            // 
            // createTypeComboBox
            // 
            this.createTypeComboBox.FormattingEnabled = true;
            this.createTypeComboBox.Items.AddRange(new object[] {
            "Проект",
            "Сотрудник",
            "Клиент"});
            this.createTypeComboBox.Location = new System.Drawing.Point(42, 21);
            this.createTypeComboBox.Name = "createTypeComboBox";
            this.createTypeComboBox.Size = new System.Drawing.Size(153, 21);
            this.createTypeComboBox.TabIndex = 1;
            this.createTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.createType_SelectedIndexChanged);
            // 
            // projectPanel
            // 
            this.projectPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectPanel.Controls.Add(this.projectStatusComboBox);
            this.projectPanel.Controls.Add(this.projectOrderDatePicker);
            this.projectPanel.Controls.Add(this.projectCustomerComboBox);
            this.projectPanel.Controls.Add(this.projectCustomerLabel);
            this.projectPanel.Controls.Add(this.projectTypeComboBox);
            this.projectPanel.Controls.Add(this.projectTypeLabel);
            this.projectPanel.Controls.Add(this.projectStatusLabel);
            this.projectPanel.Controls.Add(this.projectOrderDateLabel);
            this.projectPanel.Controls.Add(this.projectTeamComboBox);
            this.projectPanel.Controls.Add(this.projectTeamLabel);
            this.projectPanel.Location = new System.Drawing.Point(0, 61);
            this.projectPanel.Name = "projectPanel";
            this.projectPanel.Size = new System.Drawing.Size(337, 169);
            this.projectPanel.TabIndex = 2;
            // 
            // projectStatusComboBox
            // 
            this.projectStatusComboBox.FormattingEnabled = true;
            this.projectStatusComboBox.Location = new System.Drawing.Point(7, 101);
            this.projectStatusComboBox.Name = "projectStatusComboBox";
            this.projectStatusComboBox.Size = new System.Drawing.Size(151, 21);
            this.projectStatusComboBox.TabIndex = 11;
            // 
            // projectOrderDatePicker
            // 
            this.projectOrderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectOrderDatePicker.Location = new System.Drawing.Point(7, 62);
            this.projectOrderDatePicker.Name = "projectOrderDatePicker";
            this.projectOrderDatePicker.Size = new System.Drawing.Size(151, 20);
            this.projectOrderDatePicker.TabIndex = 10;
            // 
            // projectCustomerComboBox
            // 
            this.projectCustomerComboBox.FormattingEnabled = true;
            this.projectCustomerComboBox.Location = new System.Drawing.Point(174, 21);
            this.projectCustomerComboBox.Name = "projectCustomerComboBox";
            this.projectCustomerComboBox.Size = new System.Drawing.Size(151, 21);
            this.projectCustomerComboBox.TabIndex = 9;
            // 
            // projectCustomerLabel
            // 
            this.projectCustomerLabel.AutoSize = true;
            this.projectCustomerLabel.Location = new System.Drawing.Point(171, 4);
            this.projectCustomerLabel.Name = "projectCustomerLabel";
            this.projectCustomerLabel.Size = new System.Drawing.Size(46, 13);
            this.projectCustomerLabel.TabIndex = 8;
            this.projectCustomerLabel.Text = "Клиент:";
            // 
            // projectTypeComboBox
            // 
            this.projectTypeComboBox.FormattingEnabled = true;
            this.projectTypeComboBox.Location = new System.Drawing.Point(7, 140);
            this.projectTypeComboBox.Name = "projectTypeComboBox";
            this.projectTypeComboBox.Size = new System.Drawing.Size(151, 21);
            this.projectTypeComboBox.TabIndex = 7;
            // 
            // projectTypeLabel
            // 
            this.projectTypeLabel.AutoSize = true;
            this.projectTypeLabel.Location = new System.Drawing.Point(4, 125);
            this.projectTypeLabel.Name = "projectTypeLabel";
            this.projectTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.projectTypeLabel.TabIndex = 6;
            this.projectTypeLabel.Text = "Тип проекта:";
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.AutoSize = true;
            this.projectStatusLabel.Location = new System.Drawing.Point(4, 85);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(88, 13);
            this.projectStatusLabel.TabIndex = 4;
            this.projectStatusLabel.Text = "Статус проекта:";
            // 
            // projectOrderDateLabel
            // 
            this.projectOrderDateLabel.AutoSize = true;
            this.projectOrderDateLabel.Location = new System.Drawing.Point(4, 45);
            this.projectOrderDateLabel.Name = "projectOrderDateLabel";
            this.projectOrderDateLabel.Size = new System.Drawing.Size(75, 13);
            this.projectOrderDateLabel.TabIndex = 3;
            this.projectOrderDateLabel.Text = "Дата заказа:";
            // 
            // projectTeamComboBox
            // 
            this.projectTeamComboBox.FormattingEnabled = true;
            this.projectTeamComboBox.Location = new System.Drawing.Point(7, 21);
            this.projectTeamComboBox.Name = "projectTeamComboBox";
            this.projectTeamComboBox.Size = new System.Drawing.Size(151, 21);
            this.projectTeamComboBox.TabIndex = 1;
            // 
            // projectTeamLabel
            // 
            this.projectTeamLabel.AutoSize = true;
            this.projectTeamLabel.Location = new System.Drawing.Point(4, 4);
            this.projectTeamLabel.Name = "projectTeamLabel";
            this.projectTeamLabel.Size = new System.Drawing.Size(55, 13);
            this.projectTeamLabel.TabIndex = 0;
            this.projectTeamLabel.Text = "Команда:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(212, 10);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(116, 41);
            this.createButton.TabIndex = 3;
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // employeePositionComboBox
            // 
            this.employeePositionComboBox.FormattingEnabled = true;
            this.employeePositionComboBox.Location = new System.Drawing.Point(7, 62);
            this.employeePositionComboBox.Name = "employeePositionComboBox";
            this.employeePositionComboBox.Size = new System.Drawing.Size(151, 21);
            this.employeePositionComboBox.TabIndex = 5;
            // 
            // employeePanel
            // 
            this.employeePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeePanel.Controls.Add(this.employeeApplyDatePicker);
            this.employeePanel.Controls.Add(this.employeeApplyDateLabel);
            this.employeePanel.Controls.Add(this.employeePhoneTextBox);
            this.employeePanel.Controls.Add(this.employeePhoneLabel);
            this.employeePanel.Controls.Add(this.employeeHomeAddressTextBox);
            this.employeePanel.Controls.Add(this.employeeHomeAddressLabel);
            this.employeePanel.Controls.Add(this.employeeBirthDatePicker);
            this.employeePanel.Controls.Add(this.employeeBirthDateLabel);
            this.employeePanel.Controls.Add(this.employeeLastNameTextBox);
            this.employeePanel.Controls.Add(this.employeeLastNameLabel);
            this.employeePanel.Controls.Add(this.employeeFirstNameTextBox);
            this.employeePanel.Controls.Add(this.employeeFirstNameLabel);
            this.employeePanel.Controls.Add(this.employeePositionComboBox);
            this.employeePanel.Controls.Add(this.employeePositionLabel);
            this.employeePanel.Controls.Add(this.employeeTeamComboBox);
            this.employeePanel.Controls.Add(this.employeeTeamLabel);
            this.employeePanel.Location = new System.Drawing.Point(0, 61);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(337, 169);
            this.employeePanel.TabIndex = 4;
            // 
            // employeeApplyDatePicker
            // 
            this.employeeApplyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.employeeApplyDatePicker.Location = new System.Drawing.Point(177, 143);
            this.employeeApplyDatePicker.Name = "employeeApplyDatePicker";
            this.employeeApplyDatePicker.Size = new System.Drawing.Size(151, 20);
            this.employeeApplyDatePicker.TabIndex = 23;
            // 
            // employeeApplyDateLabel
            // 
            this.employeeApplyDateLabel.AutoSize = true;
            this.employeeApplyDateLabel.Location = new System.Drawing.Point(174, 126);
            this.employeeApplyDateLabel.Name = "employeeApplyDateLabel";
            this.employeeApplyDateLabel.Size = new System.Drawing.Size(77, 13);
            this.employeeApplyDateLabel.TabIndex = 22;
            this.employeeApplyDateLabel.Text = "Дата приёма:";
            // 
            // employeePhoneTextBox
            // 
            this.employeePhoneTextBox.Location = new System.Drawing.Point(177, 103);
            this.employeePhoneTextBox.Name = "employeePhoneTextBox";
            this.employeePhoneTextBox.Size = new System.Drawing.Size(151, 20);
            this.employeePhoneTextBox.TabIndex = 21;
            // 
            // employeePhoneLabel
            // 
            this.employeePhoneLabel.AutoSize = true;
            this.employeePhoneLabel.Location = new System.Drawing.Point(174, 87);
            this.employeePhoneLabel.Name = "employeePhoneLabel";
            this.employeePhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.employeePhoneLabel.TabIndex = 20;
            this.employeePhoneLabel.Text = "Телефон:";
            // 
            // employeeHomeAddressTextBox
            // 
            this.employeeHomeAddressTextBox.Location = new System.Drawing.Point(177, 63);
            this.employeeHomeAddressTextBox.Name = "employeeHomeAddressTextBox";
            this.employeeHomeAddressTextBox.Size = new System.Drawing.Size(151, 20);
            this.employeeHomeAddressTextBox.TabIndex = 19;
            // 
            // employeeHomeAddressLabel
            // 
            this.employeeHomeAddressLabel.AutoSize = true;
            this.employeeHomeAddressLabel.Location = new System.Drawing.Point(174, 47);
            this.employeeHomeAddressLabel.Name = "employeeHomeAddressLabel";
            this.employeeHomeAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.employeeHomeAddressLabel.TabIndex = 18;
            this.employeeHomeAddressLabel.Text = "Адрес:";
            // 
            // employeeBirthDatePicker
            // 
            this.employeeBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.employeeBirthDatePicker.Location = new System.Drawing.Point(177, 22);
            this.employeeBirthDatePicker.Name = "employeeBirthDatePicker";
            this.employeeBirthDatePicker.Size = new System.Drawing.Size(151, 20);
            this.employeeBirthDatePicker.TabIndex = 17;
            // 
            // employeeBirthDateLabel
            // 
            this.employeeBirthDateLabel.AutoSize = true;
            this.employeeBirthDateLabel.Location = new System.Drawing.Point(174, 5);
            this.employeeBirthDateLabel.Name = "employeeBirthDateLabel";
            this.employeeBirthDateLabel.Size = new System.Drawing.Size(89, 13);
            this.employeeBirthDateLabel.TabIndex = 16;
            this.employeeBirthDateLabel.Text = "Дата рождения:";
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(7, 143);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.employeeLastNameTextBox.TabIndex = 15;
            // 
            // employeeLastNameLabel
            // 
            this.employeeLastNameLabel.AutoSize = true;
            this.employeeLastNameLabel.Location = new System.Drawing.Point(4, 126);
            this.employeeLastNameLabel.Name = "employeeLastNameLabel";
            this.employeeLastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.employeeLastNameLabel.TabIndex = 14;
            this.employeeLastNameLabel.Text = "Фамилия:";
            // 
            // employeeFirstNameTextBox
            // 
            this.employeeFirstNameTextBox.Location = new System.Drawing.Point(7, 104);
            this.employeeFirstNameTextBox.Name = "employeeFirstNameTextBox";
            this.employeeFirstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.employeeFirstNameTextBox.TabIndex = 13;
            // 
            // employeeFirstNameLabel
            // 
            this.employeeFirstNameLabel.AutoSize = true;
            this.employeeFirstNameLabel.Location = new System.Drawing.Point(4, 88);
            this.employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            this.employeeFirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.employeeFirstNameLabel.TabIndex = 12;
            this.employeeFirstNameLabel.Text = "Имя:";
            // 
            // employeePositionLabel
            // 
            this.employeePositionLabel.AutoSize = true;
            this.employeePositionLabel.Location = new System.Drawing.Point(4, 47);
            this.employeePositionLabel.Name = "employeePositionLabel";
            this.employeePositionLabel.Size = new System.Drawing.Size(68, 13);
            this.employeePositionLabel.TabIndex = 10;
            this.employeePositionLabel.Text = "Должность:";
            // 
            // employeeTeamComboBox
            // 
            this.employeeTeamComboBox.FormattingEnabled = true;
            this.employeeTeamComboBox.Location = new System.Drawing.Point(7, 21);
            this.employeeTeamComboBox.Name = "employeeTeamComboBox";
            this.employeeTeamComboBox.Size = new System.Drawing.Size(151, 21);
            this.employeeTeamComboBox.TabIndex = 9;
            // 
            // employeeTeamLabel
            // 
            this.employeeTeamLabel.AutoSize = true;
            this.employeeTeamLabel.Location = new System.Drawing.Point(4, 4);
            this.employeeTeamLabel.Name = "employeeTeamLabel";
            this.employeeTeamLabel.Size = new System.Drawing.Size(55, 13);
            this.employeeTeamLabel.TabIndex = 8;
            this.employeeTeamLabel.Text = "Команда:";
            // 
            // customerPanel
            // 
            this.customerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerPanel.Controls.Add(this.splitter1);
            this.customerPanel.Controls.Add(this.customerPhoneTextBox);
            this.customerPanel.Controls.Add(this.customerPhoneLabel);
            this.customerPanel.Controls.Add(this.customerEmailTextBox);
            this.customerPanel.Controls.Add(this.customerEmailLabel);
            this.customerPanel.Controls.Add(this.customerLastNameTextBox);
            this.customerPanel.Controls.Add(this.customerLastNameLabel);
            this.customerPanel.Controls.Add(this.customerFirstNameTextBox);
            this.customerPanel.Controls.Add(this.customerFirstNameLabel);
            this.customerPanel.Location = new System.Drawing.Point(0, 61);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(336, 168);
            this.customerPanel.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 164);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(7, 137);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(151, 20);
            this.customerPhoneTextBox.TabIndex = 23;
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(4, 120);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.customerPhoneLabel.TabIndex = 22;
            this.customerPhoneLabel.Text = "Телефон:";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(7, 98);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(151, 20);
            this.customerEmailTextBox.TabIndex = 21;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(4, 82);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(40, 13);
            this.customerEmailLabel.TabIndex = 20;
            this.customerEmailLabel.Text = "Почта:";
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(7, 61);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.customerLastNameTextBox.TabIndex = 19;
            // 
            // customerLastNameLabel
            // 
            this.customerLastNameLabel.AutoSize = true;
            this.customerLastNameLabel.Location = new System.Drawing.Point(4, 44);
            this.customerLastNameLabel.Name = "customerLastNameLabel";
            this.customerLastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.customerLastNameLabel.TabIndex = 18;
            this.customerLastNameLabel.Text = "Фамилия:";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(7, 22);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.customerFirstNameTextBox.TabIndex = 17;
            // 
            // customerFirstNameLabel
            // 
            this.customerFirstNameLabel.AutoSize = true;
            this.customerFirstNameLabel.Location = new System.Drawing.Point(4, 6);
            this.customerFirstNameLabel.Name = "customerFirstNameLabel";
            this.customerFirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.customerFirstNameLabel.TabIndex = 16;
            this.customerFirstNameLabel.Text = "Имя:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 230);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.createTypeComboBox);
            this.Controls.Add(this.createTypeLabel);
            this.Controls.Add(this.employeePanel);
            this.Controls.Add(this.projectPanel);
            this.Controls.Add(this.customerPanel);
            this.Name = "AddForm";
            this.projectPanel.ResumeLayout(false);
            this.projectPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTypeLabel;
        private System.Windows.Forms.ComboBox createTypeComboBox;
        private System.Windows.Forms.Panel projectPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox projectStatusComboBox;
        private System.Windows.Forms.DateTimePicker projectOrderDatePicker;
        private System.Windows.Forms.ComboBox projectCustomerComboBox;
        private System.Windows.Forms.Label projectCustomerLabel;
        private System.Windows.Forms.ComboBox projectTypeComboBox;
        private System.Windows.Forms.Label projectTypeLabel;
        private System.Windows.Forms.Label projectStatusLabel;
        private System.Windows.Forms.Label projectOrderDateLabel;
        private System.Windows.Forms.ComboBox projectTeamComboBox;
        private System.Windows.Forms.Label projectTeamLabel;
        private System.Windows.Forms.ComboBox employeePositionComboBox;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.DateTimePicker employeeApplyDatePicker;
        private System.Windows.Forms.Label employeeApplyDateLabel;
        private System.Windows.Forms.TextBox employeePhoneTextBox;
        private System.Windows.Forms.Label employeePhoneLabel;
        private System.Windows.Forms.TextBox employeeHomeAddressTextBox;
        private System.Windows.Forms.Label employeeHomeAddressLabel;
        private System.Windows.Forms.DateTimePicker employeeBirthDatePicker;
        private System.Windows.Forms.Label employeeBirthDateLabel;
        private System.Windows.Forms.TextBox employeeLastNameTextBox;
        private System.Windows.Forms.Label employeeLastNameLabel;
        private System.Windows.Forms.TextBox employeeFirstNameTextBox;
        private System.Windows.Forms.Label employeeFirstNameLabel;
        private System.Windows.Forms.Label employeePositionLabel;
        private System.Windows.Forms.ComboBox employeeTeamComboBox;
        private System.Windows.Forms.Label employeeTeamLabel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.Label customerLastNameLabel;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Label customerFirstNameLabel;
        private System.Windows.Forms.Splitter splitter1;
    }
}