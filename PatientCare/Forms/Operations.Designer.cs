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
            Btn_VacCalender = new ReaLTaiizor.Controls.FoxButton();
            Btn_AddPatient = new ReaLTaiizor.Controls.FoxButton();
            Btn_AddClient = new ReaLTaiizor.Controls.FoxButton();
            Btn_EditPatient = new ReaLTaiizor.Controls.FoxButton();
            Btn_EditClient = new ReaLTaiizor.Controls.FoxButton();
            Lbl_ClientPatients = new ReaLTaiizor.Controls.FoxBigLabel();
            Lbl_Operations = new ReaLTaiizor.Controls.FoxBigLabel();
            panel1 = new Panel();
            Dgw_OwnerList = new DataGridView();
            patientOwnerBindingSource = new BindingSource(components);
            Txt_Search = new TextBox();
            panel2 = new Panel();
            foxButton3 = new ReaLTaiizor.Controls.FoxButton();
            foxButton4 = new ReaLTaiizor.Controls.FoxButton();
            foxButton2 = new ReaLTaiizor.Controls.FoxButton();
            Dgw_ToDoList = new DataGridView();
            Lbl_ToDo = new ReaLTaiizor.Controls.FoxBigLabel();
            panel3 = new Panel();
            Txt_Phone = new TextBox();
            Txt_Adress = new TextBox();
            Txt_Name = new TextBox();
            foxButton1 = new ReaLTaiizor.Controls.FoxButton();
            Btn_Sale = new ReaLTaiizor.Controls.FoxButton();
            Btn_Delete = new ReaLTaiizor.Controls.FoxButton();
            Btn_PatientDelete = new ReaLTaiizor.Controls.FoxButton();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            patientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientGenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            PatientNote = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ownerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            Lbl_ClientInfo.Text = "Hasta Sahibi Bilgileri";
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
            Lbl_Adress.Location = new Point(57, 99);
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
            Lbl_Phone.Location = new Point(43, 137);
            Lbl_Phone.Margin = new Padding(4, 0, 4, 0);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(85, 30);
            Lbl_Phone.TabIndex = 6;
            Lbl_Phone.Text = "Telefon:";
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
            Dgw_PatientList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, patientNameDataGridViewTextBoxColumn, patientGenderDataGridViewTextBoxColumn, BirthDate, PatientNote });
            Dgw_PatientList.DataSource = patientBindingSource1;
            Dgw_PatientList.Location = new Point(12, 233);
            Dgw_PatientList.Margin = new Padding(4, 3, 4, 3);
            Dgw_PatientList.Name = "Dgw_PatientList";
            Dgw_PatientList.Size = new Size(524, 150);
            Dgw_PatientList.TabIndex = 7;
            Dgw_PatientList.CellClick += Dgw_PatientList_CellClick;
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
            Btn_VacCalender.Location = new Point(436, 389);
            Btn_VacCalender.Margin = new Padding(4, 3, 4, 3);
            Btn_VacCalender.Name = "Btn_VacCalender";
            Btn_VacCalender.OverColor = Color.FromArgb(242, 242, 242);
            Btn_VacCalender.Size = new Size(100, 40);
            Btn_VacCalender.TabIndex = 8;
            Btn_VacCalender.Text = "Yapılacak Ekle";
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
            Btn_AddPatient.Location = new Point(12, 389);
            Btn_AddPatient.Margin = new Padding(4, 3, 4, 3);
            Btn_AddPatient.Name = "Btn_AddPatient";
            Btn_AddPatient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_AddPatient.RightToLeft = RightToLeft.No;
            Btn_AddPatient.Size = new Size(103, 40);
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
            Btn_AddClient.Location = new Point(359, 62);
            Btn_AddClient.Margin = new Padding(4, 3, 4, 3);
            Btn_AddClient.Name = "Btn_AddClient";
            Btn_AddClient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_AddClient.RightToLeft = RightToLeft.No;
            Btn_AddClient.Size = new Size(175, 40);
            Btn_AddClient.TabIndex = 8;
            Btn_AddClient.Text = "Hasta Sahibi Ekle";
            Btn_AddClient.Click += Btn_AddClient_Click;
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
            Btn_EditPatient.Location = new Point(123, 389);
            Btn_EditPatient.Margin = new Padding(4, 3, 4, 3);
            Btn_EditPatient.Name = "Btn_EditPatient";
            Btn_EditPatient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_EditPatient.Size = new Size(162, 40);
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
            Btn_EditClient.Location = new Point(359, 108);
            Btn_EditClient.Margin = new Padding(4, 3, 4, 3);
            Btn_EditClient.Name = "Btn_EditClient";
            Btn_EditClient.OverColor = Color.FromArgb(242, 242, 242);
            Btn_EditClient.Size = new Size(175, 40);
            Btn_EditClient.TabIndex = 8;
            Btn_EditClient.Text = "Hasta Sahibi Bilgileri Düzelt";
            Btn_EditClient.Click += Btn_EditClient_Click;
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
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(Dgw_OwnerList);
            panel1.Controls.Add(Txt_Search);
            panel1.Controls.Add(Btn_Search);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 589);
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
            Dgw_OwnerList.Size = new Size(301, 521);
            Dgw_OwnerList.TabIndex = 4;
            Dgw_OwnerList.CellClick += Dgw_OwnerList_CellClick_1;
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
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(foxButton3);
            panel2.Controls.Add(foxButton4);
            panel2.Controls.Add(foxButton2);
            panel2.Controls.Add(Dgw_ToDoList);
            panel2.Controls.Add(Lbl_ToDo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(870, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 589);
            panel2.TabIndex = 10;
            // 
            // foxButton3
            // 
            foxButton3.BackColor = Color.Transparent;
            foxButton3.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton3.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton3.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton3.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton3.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton3.DownColor = Color.FromArgb(232, 232, 232);
            foxButton3.EnabledCalc = true;
            foxButton3.Font = new Font("Segoe UI", 10F);
            foxButton3.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton3.Location = new Point(88, 60);
            foxButton3.Name = "foxButton3";
            foxButton3.OverColor = Color.FromArgb(242, 242, 242);
            foxButton3.Size = new Size(103, 40);
            foxButton3.TabIndex = 4;
            foxButton3.Text = "Bugüne Kadar";
            // 
            // foxButton4
            // 
            foxButton4.BackColor = Color.Transparent;
            foxButton4.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton4.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton4.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton4.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton4.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton4.DownColor = Color.FromArgb(232, 232, 232);
            foxButton4.EnabledCalc = true;
            foxButton4.Font = new Font("Segoe UI", 10F);
            foxButton4.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton4.Location = new Point(197, 60);
            foxButton4.Name = "foxButton4";
            foxButton4.OverColor = Color.FromArgb(242, 242, 242);
            foxButton4.Size = new Size(111, 40);
            foxButton4.TabIndex = 4;
            foxButton4.Text = "Gelecektekiler";
            // 
            // foxButton2
            // 
            foxButton2.BackColor = Color.Transparent;
            foxButton2.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton2.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton2.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton2.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton2.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton2.DownColor = Color.FromArgb(232, 232, 232);
            foxButton2.EnabledCalc = true;
            foxButton2.Font = new Font("Segoe UI", 10F);
            foxButton2.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton2.Location = new Point(16, 60);
            foxButton2.Name = "foxButton2";
            foxButton2.OverColor = Color.FromArgb(242, 242, 242);
            foxButton2.Size = new Size(66, 40);
            foxButton2.TabIndex = 4;
            foxButton2.Text = "Bugün";
            // 
            // Dgw_ToDoList
            // 
            Dgw_ToDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_ToDoList.Location = new Point(16, 108);
            Dgw_ToDoList.Margin = new Padding(4, 3, 4, 3);
            Dgw_ToDoList.Name = "Dgw_ToDoList";
            Dgw_ToDoList.Size = new Size(292, 466);
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
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(Txt_Phone);
            panel3.Controls.Add(Txt_Adress);
            panel3.Controls.Add(Txt_Name);
            panel3.Controls.Add(Lbl_ClientInfo);
            panel3.Controls.Add(Lbl_Phone);
            panel3.Controls.Add(foxButton1);
            panel3.Controls.Add(Btn_Sale);
            panel3.Controls.Add(Btn_Delete);
            panel3.Controls.Add(Btn_EditClient);
            panel3.Controls.Add(Btn_AddClient);
            panel3.Controls.Add(Btn_EditPatient);
            panel3.Controls.Add(Lbl_Name);
            panel3.Controls.Add(Btn_PatientDelete);
            panel3.Controls.Add(Btn_AddPatient);
            panel3.Controls.Add(Lbl_Adress);
            panel3.Controls.Add(Lbl_ClientPatients);
            panel3.Controls.Add(Dgw_PatientList);
            panel3.Controls.Add(Lbl_Operations);
            panel3.Controls.Add(Btn_VacCalender);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(317, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(553, 589);
            panel3.TabIndex = 11;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = SystemColors.Control;
            Txt_Phone.Enabled = false;
            Txt_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Phone.Location = new Point(124, 138);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(214, 29);
            Txt_Phone.TabIndex = 9;
            // 
            // Txt_Adress
            // 
            Txt_Adress.BackColor = SystemColors.Control;
            Txt_Adress.Enabled = false;
            Txt_Adress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Adress.Location = new Point(124, 100);
            Txt_Adress.Name = "Txt_Adress";
            Txt_Adress.Size = new Size(214, 29);
            Txt_Adress.TabIndex = 9;
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = SystemColors.Control;
            Txt_Name.Enabled = false;
            Txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Name.Location = new Point(124, 63);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(214, 29);
            Txt_Name.TabIndex = 9;
            // 
            // foxButton1
            // 
            foxButton1.BackColor = Color.Transparent;
            foxButton1.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton1.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton1.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton1.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton1.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton1.DownColor = Color.FromArgb(232, 232, 232);
            foxButton1.EnabledCalc = true;
            foxButton1.Font = new Font("Segoe UI", 10F);
            foxButton1.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton1.Location = new Point(167, 483);
            foxButton1.Margin = new Padding(4, 3, 4, 3);
            foxButton1.Name = "foxButton1";
            foxButton1.OverColor = Color.FromArgb(242, 242, 242);
            foxButton1.Size = new Size(147, 40);
            foxButton1.TabIndex = 8;
            foxButton1.Text = "Satış İşlemleri";
            // 
            // Btn_Sale
            // 
            Btn_Sale.BackColor = Color.Transparent;
            Btn_Sale.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_Sale.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_Sale.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_Sale.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_Sale.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_Sale.DownColor = Color.FromArgb(232, 232, 232);
            Btn_Sale.EnabledCalc = true;
            Btn_Sale.Font = new Font("Segoe UI", 10F);
            Btn_Sale.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Sale.Location = new Point(12, 483);
            Btn_Sale.Margin = new Padding(4, 3, 4, 3);
            Btn_Sale.Name = "Btn_Sale";
            Btn_Sale.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Sale.Size = new Size(147, 40);
            Btn_Sale.TabIndex = 8;
            Btn_Sale.Text = "Satış İşlemleri";
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = Color.Transparent;
            Btn_Delete.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_Delete.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_Delete.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_Delete.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_Delete.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_Delete.DownColor = Color.FromArgb(232, 232, 232);
            Btn_Delete.EnabledCalc = true;
            Btn_Delete.Font = new Font("Segoe UI", 10F);
            Btn_Delete.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Delete.Location = new Point(359, 154);
            Btn_Delete.Margin = new Padding(4, 3, 4, 3);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Delete.Size = new Size(175, 40);
            Btn_Delete.TabIndex = 8;
            Btn_Delete.Text = "Hasta Sahibi Kaydını Sil";
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_PatientDelete
            // 
            Btn_PatientDelete.BackColor = Color.Transparent;
            Btn_PatientDelete.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_PatientDelete.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_PatientDelete.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_PatientDelete.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_PatientDelete.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_PatientDelete.DownColor = Color.FromArgb(232, 232, 232);
            Btn_PatientDelete.EnabledCalc = true;
            Btn_PatientDelete.Font = new Font("Segoe UI", 10F);
            Btn_PatientDelete.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_PatientDelete.Location = new Point(293, 389);
            Btn_PatientDelete.Margin = new Padding(4, 3, 4, 3);
            Btn_PatientDelete.Name = "Btn_PatientDelete";
            Btn_PatientDelete.OverColor = Color.FromArgb(242, 242, 242);
            Btn_PatientDelete.RightToLeft = RightToLeft.No;
            Btn_PatientDelete.Size = new Size(135, 40);
            Btn_PatientDelete.TabIndex = 8;
            Btn_PatientDelete.Text = "Hayvan Kaydını Sil";
            Btn_PatientDelete.Click += Btn_PatientDelete_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            patientNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // patientGenderDataGridViewTextBoxColumn
            // 
            patientGenderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            patientGenderDataGridViewTextBoxColumn.DataPropertyName = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.HeaderText = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.Name = "patientGenderDataGridViewTextBoxColumn";
            patientGenderDataGridViewTextBoxColumn.Width = 107;
            // 
            // BirthDate
            // 
            BirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 42;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            ownerNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            ownerNameDataGridViewTextBoxColumn.HeaderText = "OwnerName";
            ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientCare v0.01";
            Resize += Operations_Resize;
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
            PerformLayout();
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
        private ReaLTaiizor.Controls.FoxButton Btn_VacCalender;
        private ReaLTaiizor.Controls.FoxButton Btn_AddPatient;
        private ReaLTaiizor.Controls.FoxButton Btn_AddClient;
        private ReaLTaiizor.Controls.FoxButton Btn_EditPatient;
        private ReaLTaiizor.Controls.FoxButton Btn_EditClient;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_ClientPatients;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_Operations;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Dgw_ToDoList;
        private ReaLTaiizor.Controls.FoxBigLabel Lbl_ToDo;
        private Panel panel3;
        private TextBox Txt_Search;
        private DataGridView Dgw_OwnerList;
        private BindingSource patientOwnerBindingSource;
        private TextBox Txt_Phone;
        private TextBox Txt_Adress;
        private TextBox Txt_Name;
        private ReaLTaiizor.Controls.FoxButton Btn_Sale;
        private ReaLTaiizor.Controls.FoxButton foxButton1;
        private ReaLTaiizor.Controls.FoxButton Btn_Delete;
        private ReaLTaiizor.Controls.FoxButton foxButton3;
        private ReaLTaiizor.Controls.FoxButton foxButton4;
        private ReaLTaiizor.Controls.FoxButton foxButton2;
        private ReaLTaiizor.Controls.FoxButton Btn_PatientDelete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientGenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn PatientNote;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
    }
}