namespace PatientCare.Forms
{
    partial class Operations
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operations));
            Btn_Search = new ReaLTaiizor.Controls.FoxButton();
            Lbl_ClientInfo = new ReaLTaiizor.Controls.FoxBigLabel();
            Lbl_Name = new Label();
            Lbl_Adress = new Label();
            Lbl_Phone = new Label();
            patientBindingSource = new BindingSource(components);
            patientBindingSource1 = new BindingSource(components);
            patientBindingSource2 = new BindingSource(components);
            patientBindingSource3 = new BindingSource(components);
            Dgw_PatientList = new DataGridView();
            patientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientGenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            PatientNote = new DataGridViewTextBoxColumn();
            Btn_PatientInfo = new ReaLTaiizor.Controls.FoxButton();
            Btn_VacCalender = new ReaLTaiizor.Controls.FoxButton();
            Btn_Sales = new ReaLTaiizor.Controls.FoxButton();
            Btn_Desease = new ReaLTaiizor.Controls.FoxButton();
            Btn_AddPatient = new ReaLTaiizor.Controls.FoxButton();
            Btn_AddClient = new ReaLTaiizor.Controls.FoxButton();
            Btn_SaleInfo = new ReaLTaiizor.Controls.FoxButton();
            Btn_EditPatient = new ReaLTaiizor.Controls.FoxButton();
            Btn_EditClient = new ReaLTaiizor.Controls.FoxButton();
            Lbl_ClientPatients = new ReaLTaiizor.Controls.FoxBigLabel();
            Lbl_Operations = new ReaLTaiizor.Controls.FoxBigLabel();
            Txt_Name = new ReaLTaiizor.Controls.FoxTextBox();
            Txt_Adress = new ReaLTaiizor.Controls.FoxTextBox();
            Txt_Phone = new ReaLTaiizor.Controls.FoxTextBox();
            panel1 = new Panel();
            Dgw_OwnerList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ownerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientOwnerBindingSource = new BindingSource(components);
            Txt_Search = new TextBox();
            panel2 = new Panel();
            Dgw_ToDoList = new DataGridView();
            Lbl_ToDo = new ReaLTaiizor.Controls.FoxBigLabel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgw_PatientList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgw_OwnerList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgw_ToDoList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Search
            // 
            Btn_Search.BackColor = Color.Transparent;
            Btn_Search.BackgroundImage = (Image)resources.GetObject("Btn_Search.BackgroundImage");
            Btn_Search.BackgroundImageLayout = ImageLayout.None;
            Btn_Search.BaseColor = Color.Transparent;
            Btn_Search.BorderColor = Color.Transparent;
            Btn_Search.DisabledBaseColor = Color.Transparent;
            Btn_Search.DisabledBorderColor = Color.Transparent;
            Btn_Search.DisabledTextColor = Color.Transparent;
            Btn_Search.DownColor = Color.Transparent;
            Btn_Search.EnabledCalc = true;
            Btn_Search.Font = new Font("Segoe UI", 10F);
            Btn_Search.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Search.Location = new Point(282, 15);
            Btn_Search.Margin = new Padding(4, 3, 4, 3);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.OverColor = Color.Transparent;
            Btn_Search.Size = new Size(31, 32);
            Btn_Search.TabIndex = 1;
            Btn_Search.Click += Btn_Search_Click;
            // 
            // Lbl_ClientInfo
            // 
            Lbl_ClientInfo.BackColor = Color.Transparent;
            Lbl_ClientInfo.Font = new Font("Segoe UI Semibold", 20F);
            Lbl_ClientInfo.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_ClientInfo.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            Lbl_ClientInfo.LineColor = Color.FromArgb(200, 200, 200);
            Lbl_ClientInfo.Location = new Point(12, 12);
            Lbl_ClientInfo.Margin = new Padding(4, 3, 4, 3);
            Lbl_ClientInfo.Name = "Lbl_ClientInfo";
            Lbl_ClientInfo.Size = new Size(524, 42);
            Lbl_ClientInfo.TabIndex = 3;
            Lbl_ClientInfo.Text = "Müşteri Bilgileri";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Name.Location = new Point(12, 62);
            Lbl_Name.Margin = new Padding(4, 0, 4, 0);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(116, 30);
            Lbl_Name.TabIndex = 6;
            Lbl_Name.Text = "Adı Soyadı:";
            Lbl_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Adress
            // 
            Lbl_Adress.AutoSize = true;
            Lbl_Adress.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Adress.Location = new Point(12, 100);
            Lbl_Adress.Margin = new Padding(4, 0, 4, 0);
            Lbl_Adress.Name = "Lbl_Adress";
            Lbl_Adress.Size = new Size(71, 30);
            Lbl_Adress.TabIndex = 6;
            Lbl_Adress.Text = "Adres:";
            Lbl_Adress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.AutoSize = true;
            Lbl_Phone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Phone.Location = new Point(12, 138);
            Lbl_Phone.Margin = new Padding(4, 0, 4, 0);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(119, 30);
            Lbl_Phone.TabIndex = 6;
            Lbl_Phone.Text = "Telefon No:";
            Lbl_Phone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Models.Patient);
            // 
            // patientBindingSource1
            // 
            patientBindingSource1.DataSource = typeof(Models.Patient);
            // 
            // patientBindingSource2
            // 
            patientBindingSource2.DataSource = typeof(Models.Patient);
            // 
            // patientBindingSource3
            // 
            patientBindingSource3.DataSource = typeof(Models.Patient);
            // 
            // Dgw_PatientList
            // 
            Dgw_PatientList.AutoGenerateColumns = false;
            Dgw_PatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_PatientList.Columns.AddRange(new DataGridViewColumn[] { patientNameDataGridViewTextBoxColumn, patientGenderDataGridViewTextBoxColumn, BirthDate, PatientNote });
            Dgw_PatientList.DataSource = patientBindingSource1;
            Dgw_PatientList.Location = new Point(12, 233);
            Dgw_PatientList.Margin = new Padding(4, 3, 4, 3);
            Dgw_PatientList.Name = "Dgw_PatientList";
            Dgw_PatientList.Size = new Size(524, 150);
            Dgw_PatientList.TabIndex = 7;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            patientNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // patientGenderDataGridViewTextBoxColumn
            // 
            patientGenderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            patientGenderDataGridViewTextBoxColumn.DataPropertyName = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.HeaderText = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.Name = "patientGenderDataGridViewTextBoxColumn";
            patientGenderDataGridViewTextBoxColumn.Width = 107;
            // 
            // BirthDate
            // 
            BirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "BirthDate";
            BirthDate.Name = "BirthDate";
            BirthDate.Width = 81;
            // 
            // PatientNote
            // 
            PatientNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PatientNote.DataPropertyName = "PatientNote";
            PatientNote.HeaderText = "PatientNote";
            PatientNote.Name = "PatientNote";
            // 
            // Btn_PatientInfo
            // 
            Btn_PatientInfo.BackColor = Color.Transparent;
            Btn_PatientInfo.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_PatientInfo.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_PatientInfo.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_PatientInfo.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_PatientInfo.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_PatientInfo.DownColor = Color.FromArgb(232, 232, 232);
            Btn_PatientInfo.EnabledCalc = true;
            Btn_PatientInfo.Font = new Font("Segoe UI", 10F);
            Btn_PatientInfo.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_PatientInfo.Location = new Point(12, 389);
            Btn_PatientInfo.Margin = new Padding(4, 3, 4, 3);
            Btn_PatientInfo.Name = "Btn_PatientInfo";
            Btn_PatientInfo.OverColor = Color.FromArgb(242, 242, 242);
            Btn_PatientInfo.Size = new Size(120, 40);
            Btn_PatientInfo.TabIndex = 8;
            Btn_PatientInfo.Text = "Hayvan Bilgileri";
            // 
            // Btn_VacCalender
            // 
            Btn_VacCalender.BackColor = Color.Transparent;
            Btn_VacCalender.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_VacCalender.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_VacCalender.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_VacCalender.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_VacCalender.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_VacCalender.DownColor = Color.FromArgb(232, 232, 232);
            Btn_VacCalender.EnabledCalc = true;
            Btn_VacCalender.Font = new Font("Segoe UI", 10F);
            Btn_VacCalender.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_VacCalender.Location = new Point(144, 389);
            Btn_VacCalender.Margin = new Padding(4, 3, 4, 3);
            Btn_VacCalender.Name = "Btn_VacCalender";
            Btn_VacCalender.OverColor = Color.FromArgb(242, 242, 242);
            Btn_VacCalender.Size = new Size(120, 40);
            Btn_VacCalender.TabIndex = 8;
            Btn_VacCalender.Text = "Aşılama Takvimi";
            // 
            // Btn_Sales
            // 
            Btn_Sales.BackColor = Color.Transparent;
            Btn_Sales.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_Sales.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_Sales.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_Sales.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_Sales.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_Sales.DownColor = Color.FromArgb(232, 232, 232);
            Btn_Sales.EnabledCalc = true;
            Btn_Sales.Font = new Font("Segoe UI", 10F);
            Btn_Sales.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Sales.Location = new Point(12, 488);
            Btn_Sales.Margin = new Padding(4, 3, 4, 3);
            Btn_Sales.Name = "Btn_Sales";
            Btn_Sales.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Sales.RightToLeft = RightToLeft.No;
            Btn_Sales.Size = new Size(120, 40);
            Btn_Sales.TabIndex = 8;
            Btn_Sales.Text = "Direkt Satış";
            // 
            // Btn_Desease
            // 
            Btn_Desease.BackColor = Color.Transparent;
            Btn_Desease.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_Desease.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_Desease.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_Desease.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_Desease.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_Desease.DownColor = Color.FromArgb(232, 232, 232);
            Btn_Desease.EnabledCalc = true;
            Btn_Desease.Font = new Font("Segoe UI", 10F);
            Btn_Desease.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Desease.Location = new Point(144, 488);
            Btn_Desease.Margin = new Padding(4, 3, 4, 3);
            Btn_Desease.Name = "Btn_Desease";
            Btn_Desease.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Desease.RightToLeft = RightToLeft.No;
            Btn_Desease.Size = new Size(120, 40);
            Btn_Desease.TabIndex = 8;
            Btn_Desease.Text = "Hastalık";
            // 
            // Btn_AddPatient
            // 
            Btn_AddPatient.BackColor = Color.Transparent;
            Btn_AddPatient.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_AddPatient.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_AddPatient.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_AddPatient.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_AddPatient.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_AddPatient.DownColor = Color.FromArgb(232, 232, 232);
            Btn_AddPatient.EnabledCalc = true;
            Btn_AddPatient.Font = new Font("Segoe UI", 10F);
            Btn_AddPatient.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_AddPatient.Location = new Point(270, 488);
            Btn_AddPatient.Margin = new Padding(4, 3, 4, 3);
            Btn_AddPatient.Name = "Btn_AddPatient";
            Btn_AddPatient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_AddPatient.RightToLeft = RightToLeft.No;
            Btn_AddPatient.Size = new Size(120, 40);
            Btn_AddPatient.TabIndex = 8;
            Btn_AddPatient.Text = "Hayvan Ekle";
            Btn_AddPatient.Click += Btn_AddPatient_Click;
            // 
            // Btn_AddClient
            // 
            Btn_AddClient.BackColor = Color.Transparent;
            Btn_AddClient.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_AddClient.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_AddClient.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_AddClient.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_AddClient.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_AddClient.DownColor = Color.FromArgb(232, 232, 232);
            Btn_AddClient.EnabledCalc = true;
            Btn_AddClient.Font = new Font("Segoe UI", 10F);
            Btn_AddClient.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_AddClient.Location = new Point(396, 488);
            Btn_AddClient.Margin = new Padding(4, 3, 4, 3);
            Btn_AddClient.Name = "Btn_AddClient";
            Btn_AddClient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_AddClient.RightToLeft = RightToLeft.No;
            Btn_AddClient.Size = new Size(120, 40);
            Btn_AddClient.TabIndex = 8;
            Btn_AddClient.Text = "Yeni Müşteri";
            Btn_AddClient.Click += Btn_AddClient_Click;
            // 
            // Btn_SaleInfo
            // 
            Btn_SaleInfo.BackColor = Color.Transparent;
            Btn_SaleInfo.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_SaleInfo.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_SaleInfo.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_SaleInfo.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_SaleInfo.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_SaleInfo.DownColor = Color.FromArgb(232, 232, 232);
            Btn_SaleInfo.EnabledCalc = true;
            Btn_SaleInfo.Font = new Font("Segoe UI", 10F);
            Btn_SaleInfo.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_SaleInfo.Location = new Point(12, 534);
            Btn_SaleInfo.Margin = new Padding(4, 3, 4, 3);
            Btn_SaleInfo.Name = "Btn_SaleInfo";
            Btn_SaleInfo.OverColor = Color.FromArgb(242, 242, 242);
            Btn_SaleInfo.Size = new Size(120, 40);
            Btn_SaleInfo.TabIndex = 8;
            Btn_SaleInfo.Text = "Satış İşlemleri";
            // 
            // Btn_EditPatient
            // 
            Btn_EditPatient.BackColor = Color.Transparent;
            Btn_EditPatient.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_EditPatient.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_EditPatient.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_EditPatient.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_EditPatient.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_EditPatient.DownColor = Color.FromArgb(232, 232, 232);
            Btn_EditPatient.EnabledCalc = true;
            Btn_EditPatient.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_EditPatient.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_EditPatient.Location = new Point(144, 534);
            Btn_EditPatient.Margin = new Padding(4, 3, 4, 3);
            Btn_EditPatient.Name = "Btn_EditPatient";
            Btn_EditPatient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_EditPatient.Size = new Size(150, 40);
            Btn_EditPatient.TabIndex = 8;
            Btn_EditPatient.Text = "Hayvan Bilgileri Düzelt";
            // 
            // Btn_EditClient
            // 
            Btn_EditClient.BackColor = Color.Transparent;
            Btn_EditClient.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_EditClient.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_EditClient.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_EditClient.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_EditClient.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_EditClient.DownColor = Color.FromArgb(232, 232, 232);
            Btn_EditClient.EnabledCalc = true;
            Btn_EditClient.Font = new Font("Segoe UI", 10F);
            Btn_EditClient.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_EditClient.Location = new Point(301, 534);
            Btn_EditClient.Margin = new Padding(4, 3, 4, 3);
            Btn_EditClient.Name = "Btn_EditClient";
            Btn_EditClient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_EditClient.Size = new Size(147, 40);
            Btn_EditClient.TabIndex = 8;
            Btn_EditClient.Text = "Müşteri Bilgileri Düzelt";
            // 
            // Lbl_ClientPatients
            // 
            Lbl_ClientPatients.BackColor = Color.Transparent;
            Lbl_ClientPatients.Font = new Font("Segoe UI Semibold", 20F);
            Lbl_ClientPatients.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_ClientPatients.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            Lbl_ClientPatients.LineColor = Color.FromArgb(200, 200, 200);
            Lbl_ClientPatients.Location = new Point(12, 186);
            Lbl_ClientPatients.Margin = new Padding(4, 3, 4, 3);
            Lbl_ClientPatients.Name = "Lbl_ClientPatients";
            Lbl_ClientPatients.Size = new Size(524, 42);
            Lbl_ClientPatients.TabIndex = 3;
            Lbl_ClientPatients.Text = "Sahibi Olduğu Hayvanlar";
            // 
            // Lbl_Operations
            // 
            Lbl_Operations.BackColor = Color.Transparent;
            Lbl_Operations.Font = new Font("Segoe UI Semibold", 20F);
            Lbl_Operations.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_Operations.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            Lbl_Operations.LineColor = Color.FromArgb(200, 200, 200);
            Lbl_Operations.Location = new Point(12, 435);
            Lbl_Operations.Margin = new Padding(4, 3, 4, 3);
            Lbl_Operations.Name = "Lbl_Operations";
            Lbl_Operations.Size = new Size(524, 42);
            Lbl_Operations.TabIndex = 3;
            Lbl_Operations.Text = "İşlemler";
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = Color.Transparent;
            Txt_Name.Enabled = false;
            Txt_Name.EnabledCalc = true;
            Txt_Name.Font = new Font("Segoe UI", 10F);
            Txt_Name.ForeColor = Color.FromArgb(66, 78, 90);
            Txt_Name.Location = new Point(144, 62);
            Txt_Name.Margin = new Padding(4, 3, 4, 3);
            Txt_Name.MaxLength = 32767;
            Txt_Name.MultiLine = false;
            Txt_Name.Name = "Txt_Name";
            Txt_Name.ReadOnly = false;
            Txt_Name.Size = new Size(178, 32);
            Txt_Name.TabIndex = 5;
            Txt_Name.TextAlign = HorizontalAlignment.Left;
            Txt_Name.UseSystemPasswordChar = false;
            // 
            // Txt_Adress
            // 
            Txt_Adress.BackColor = Color.Transparent;
            Txt_Adress.Enabled = false;
            Txt_Adress.EnabledCalc = true;
            Txt_Adress.Font = new Font("Segoe UI", 10F);
            Txt_Adress.ForeColor = Color.FromArgb(66, 78, 90);
            Txt_Adress.Location = new Point(144, 100);
            Txt_Adress.Margin = new Padding(4, 3, 4, 3);
            Txt_Adress.MaxLength = 32767;
            Txt_Adress.MultiLine = false;
            Txt_Adress.Name = "Txt_Adress";
            Txt_Adress.ReadOnly = false;
            Txt_Adress.Size = new Size(178, 32);
            Txt_Adress.TabIndex = 5;
            Txt_Adress.TextAlign = HorizontalAlignment.Left;
            Txt_Adress.UseSystemPasswordChar = false;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = Color.Transparent;
            Txt_Phone.Enabled = false;
            Txt_Phone.EnabledCalc = true;
            Txt_Phone.Font = new Font("Segoe UI", 10F);
            Txt_Phone.ForeColor = Color.FromArgb(66, 78, 90);
            Txt_Phone.Location = new Point(144, 138);
            Txt_Phone.Margin = new Padding(4, 3, 4, 3);
            Txt_Phone.MaxLength = 32767;
            Txt_Phone.MultiLine = false;
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.ReadOnly = false;
            Txt_Phone.Size = new Size(178, 32);
            Txt_Phone.TabIndex = 5;
            Txt_Phone.TextAlign = HorizontalAlignment.Left;
            Txt_Phone.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(Dgw_OwnerList);
            panel1.Controls.Add(Txt_Search);
            panel1.Controls.Add(Btn_Search);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 589);
            panel1.TabIndex = 9;
            // 
            // Dgw_OwnerList
            // 
            Dgw_OwnerList.AutoGenerateColumns = false;
            Dgw_OwnerList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Dgw_OwnerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_OwnerList.Columns.AddRange(new DataGridViewColumn[] { Id, ownerNameDataGridViewTextBoxColumn });
            Dgw_OwnerList.DataSource = patientOwnerBindingSource;
            Dgw_OwnerList.Location = new Point(12, 53);
            Dgw_OwnerList.Name = "Dgw_OwnerList";
            Dgw_OwnerList.Size = new Size(301, 509);
            Dgw_OwnerList.TabIndex = 4;
            Dgw_OwnerList.CellClick += Dgw_OwnerList_CellClick_1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 42;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            ownerNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            ownerNameDataGridViewTextBoxColumn.HeaderText = "OwnerName";
            ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            // 
            // patientOwnerBindingSource
            // 
            patientOwnerBindingSource.DataSource = typeof(Models.PatientOwner);
            // 
            // Txt_Search
            // 
            Txt_Search.BackColor = SystemColors.Control;
            Txt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Search.Location = new Point(12, 18);
            Txt_Search.Name = "Txt_Search";
            Txt_Search.PlaceholderText = "Hasta Sahibi Arama";
            Txt_Search.Size = new Size(263, 29);
            Txt_Search.TabIndex = 3;
            Txt_Search.Enter += Txt_Search_Enter_1;
            Txt_Search.Leave += Txt_Search_Leave_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dgw_ToDoList);
            panel2.Controls.Add(Lbl_ToDo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(862, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 589);
            panel2.TabIndex = 10;
            // 
            // Dgw_ToDoList
            // 
            Dgw_ToDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_ToDoList.Location = new Point(16, 67);
            Dgw_ToDoList.Margin = new Padding(4, 3, 4, 3);
            Dgw_ToDoList.Name = "Dgw_ToDoList";
            Dgw_ToDoList.Size = new Size(299, 507);
            Dgw_ToDoList.TabIndex = 0;
            // 
            // Lbl_ToDo
            // 
            Lbl_ToDo.BackColor = Color.Transparent;
            Lbl_ToDo.Font = new Font("Segoe UI Semibold", 20F);
            Lbl_ToDo.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_ToDo.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            Lbl_ToDo.LineColor = Color.FromArgb(200, 200, 200);
            Lbl_ToDo.Location = new Point(16, 12);
            Lbl_ToDo.Margin = new Padding(4, 3, 4, 3);
            Lbl_ToDo.Name = "Lbl_ToDo";
            Lbl_ToDo.Size = new Size(292, 42);
            Lbl_ToDo.TabIndex = 3;
            Lbl_ToDo.Text = "Yapılacaklar";
            // 
            // panel3
            // 
            panel3.Controls.Add(Lbl_ClientInfo);
            panel3.Controls.Add(Lbl_Phone);
            panel3.Controls.Add(Txt_Name);
            panel3.Controls.Add(Btn_EditClient);
            panel3.Controls.Add(Txt_Adress);
            panel3.Controls.Add(Btn_AddClient);
            panel3.Controls.Add(Txt_Phone);
            panel3.Controls.Add(Btn_EditPatient);
            panel3.Controls.Add(Lbl_Name);
            panel3.Controls.Add(Btn_AddPatient);
            panel3.Controls.Add(Lbl_Adress);
            panel3.Controls.Add(Btn_SaleInfo);
            panel3.Controls.Add(Btn_Desease);
            panel3.Controls.Add(Lbl_ClientPatients);
            panel3.Controls.Add(Btn_Sales);
            panel3.Controls.Add(Dgw_PatientList);
            panel3.Controls.Add(Lbl_Operations);
            panel3.Controls.Add(Btn_PatientInfo);
            panel3.Controls.Add(Btn_VacCalender);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(320, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(542, 589);
            panel3.TabIndex = 11;
            // 
            // Operations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 589);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Operations";
            Text = "PatientCare v0.01";
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgw_PatientList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgw_OwnerList).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgw_ToDoList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.FoxButton Btn_Search;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_ClientInfo;
        private Label Lbl_Name;
        private Label Lbl_Adress;
        private Label Lbl_Phone;
        private BindingSource patientBindingSource;
        private BindingSource patientBindingSource1;
        private BindingSource patientBindingSource2;
        private BindingSource patientBindingSource3;
        private DataGridView Dgw_PatientList;
        private ReaLTaiizor.Controls.FoxButton Btn_PatientInfo;
        private ReaLTaiizor.Controls.FoxButton Btn_VacCalender;
        private ReaLTaiizor.Controls.FoxButton Btn_Sales;
        private ReaLTaiizor.Controls.FoxButton Btn_Desease;
        private ReaLTaiizor.Controls.FoxButton Btn_AddPatient;
        private ReaLTaiizor.Controls.FoxButton Btn_AddClient;
        private ReaLTaiizor.Controls.FoxButton Btn_SaleInfo;
        private ReaLTaiizor.Controls.FoxButton Btn_EditPatient;
        private ReaLTaiizor.Controls.FoxButton Btn_EditClient;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_ClientPatients;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_Operations;
        private ReaLTaiizor.Controls.FoxTextBox Txt_Name;
        private ReaLTaiizor.Controls.FoxTextBox Txt_Adress;
        private ReaLTaiizor.Controls.FoxTextBox Txt_Phone;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Dgw_ToDoList;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_ToDo;
        private Panel panel3;
        private TextBox Txt_Search;
        private DataGridView Dgw_OwnerList;
        private BindingSource patientOwnerBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientGenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn PatientNote;
    }
}