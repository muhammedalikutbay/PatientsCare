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
            foxTextBox1 = new ReaLTaiizor.Controls.FoxTextBox();
            foxButton1 = new ReaLTaiizor.Controls.FoxButton();
            Dgw_OwnerList = new DataGridView();
            ownerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientOwnerBindingSource = new BindingSource(components);
            patientOwnerBindingSource1 = new BindingSource(components);
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            patientBindingSource = new BindingSource(components);
            patientBindingSource1 = new BindingSource(components);
            patientBindingSource2 = new BindingSource(components);
            patientBindingSource3 = new BindingSource(components);
            Dgw_PatientList = new DataGridView();
            patientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientGenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            foxButton2 = new ReaLTaiizor.Controls.FoxButton();
            foxButton3 = new ReaLTaiizor.Controls.FoxButton();
            foxButton4 = new ReaLTaiizor.Controls.FoxButton();
            foxButton5 = new ReaLTaiizor.Controls.FoxButton();
            foxButton6 = new ReaLTaiizor.Controls.FoxButton();
            foxButton7 = new ReaLTaiizor.Controls.FoxButton();
            foxButton8 = new ReaLTaiizor.Controls.FoxButton();
            foxButton10 = new ReaLTaiizor.Controls.FoxButton();
            foxButton11 = new ReaLTaiizor.Controls.FoxButton();
            foxBigLabel2 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxBigLabel3 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxTextBox2 = new ReaLTaiizor.Controls.FoxTextBox();
            foxTextBox3 = new ReaLTaiizor.Controls.FoxTextBox();
            foxTextBox4 = new ReaLTaiizor.Controls.FoxTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            Dgw_ToDoList = new DataGridView();
            foxBigLabel4 = new ReaLTaiizor.Controls.FoxBigLabel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Dgw_OwnerList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgw_PatientList).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgw_ToDoList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // foxTextBox1
            // 
            foxTextBox1.BackColor = Color.Transparent;
            foxTextBox1.EnabledCalc = true;
            foxTextBox1.Font = new Font("Segoe UI", 10F);
            foxTextBox1.ForeColor = Color.FromArgb(66, 78, 90);
            foxTextBox1.Location = new Point(12, 15);
            foxTextBox1.MaxLength = 32767;
            foxTextBox1.MultiLine = false;
            foxTextBox1.Name = "foxTextBox1";
            foxTextBox1.ReadOnly = false;
            foxTextBox1.Size = new Size(264, 32);
            foxTextBox1.TabIndex = 0;
            foxTextBox1.Text = "foxTextBox1";
            foxTextBox1.TextAlign = HorizontalAlignment.Left;
            foxTextBox1.UseSystemPasswordChar = false;
            // 
            // foxButton1
            // 
            foxButton1.BackColor = Color.Transparent;
            foxButton1.BackgroundImage = (Image)resources.GetObject("foxButton1.BackgroundImage");
            foxButton1.BackgroundImageLayout = ImageLayout.None;
            foxButton1.BaseColor = Color.Transparent;
            foxButton1.BorderColor = Color.Transparent;
            foxButton1.DisabledBaseColor = Color.Transparent;
            foxButton1.DisabledBorderColor = Color.Transparent;
            foxButton1.DisabledTextColor = Color.Transparent;
            foxButton1.DownColor = Color.Transparent;
            foxButton1.EnabledCalc = true;
            foxButton1.Font = new Font("Segoe UI", 10F);
            foxButton1.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton1.Location = new Point(282, 15);
            foxButton1.Name = "foxButton1";
            foxButton1.OverColor = Color.Transparent;
            foxButton1.Size = new Size(32, 32);
            foxButton1.TabIndex = 1;
            // 
            // Dgw_OwnerList
            // 
            Dgw_OwnerList.AutoGenerateColumns = false;
            Dgw_OwnerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_OwnerList.Columns.AddRange(new DataGridViewColumn[] { ownerNameDataGridViewTextBoxColumn });
            Dgw_OwnerList.DataSource = patientOwnerBindingSource;
            Dgw_OwnerList.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgw_OwnerList.Location = new Point(12, 60);
            Dgw_OwnerList.Name = "Dgw_OwnerList";
            Dgw_OwnerList.Size = new Size(302, 514);
            Dgw_OwnerList.TabIndex = 2;
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
            // patientOwnerBindingSource1
            // 
            patientOwnerBindingSource1.DataSource = typeof(Models.PatientOwner);
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(12, 12);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(524, 41);
            foxBigLabel1.TabIndex = 3;
            foxBigLabel1.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 6;
            label1.Text = "Adı Soyadı:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 6;
            label2.Text = "Adres:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(13, 138);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 6;
            label3.Text = "Telefon No:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            Dgw_PatientList.Columns.AddRange(new DataGridViewColumn[] { patientNameDataGridViewTextBoxColumn, patientGenderDataGridViewTextBoxColumn, BirthDate });
            Dgw_PatientList.DataSource = patientBindingSource1;
            Dgw_PatientList.Location = new Point(12, 233);
            Dgw_PatientList.Name = "Dgw_PatientList";
            Dgw_PatientList.Size = new Size(524, 150);
            Dgw_PatientList.TabIndex = 7;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientGenderDataGridViewTextBoxColumn
            // 
            patientGenderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patientGenderDataGridViewTextBoxColumn.DataPropertyName = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.HeaderText = "PatientGender";
            patientGenderDataGridViewTextBoxColumn.Name = "patientGenderDataGridViewTextBoxColumn";
            // 
            // BirthDate
            // 
            BirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BirthDate.HeaderText = "BirthDate";
            BirthDate.Name = "BirthDate";
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
            foxButton2.Location = new Point(12, 389);
            foxButton2.Name = "foxButton2";
            foxButton2.OverColor = Color.FromArgb(242, 242, 242);
            foxButton2.Size = new Size(120, 40);
            foxButton2.TabIndex = 8;
            foxButton2.Text = "Hayvan Bilgileri";
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
            foxButton3.Location = new Point(144, 389);
            foxButton3.Name = "foxButton3";
            foxButton3.OverColor = Color.FromArgb(242, 242, 242);
            foxButton3.Size = new Size(120, 40);
            foxButton3.TabIndex = 8;
            foxButton3.Text = "Aşılama Takvimi";
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
            foxButton4.Location = new Point(12, 488);
            foxButton4.Name = "foxButton4";
            foxButton4.OverColor = Color.FromArgb(242, 242, 242);
            foxButton4.RightToLeft = RightToLeft.No;
            foxButton4.Size = new Size(120, 40);
            foxButton4.TabIndex = 8;
            foxButton4.Text = "Direkt Satış";
            // 
            // foxButton5
            // 
            foxButton5.BackColor = Color.Transparent;
            foxButton5.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton5.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton5.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton5.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton5.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton5.DownColor = Color.FromArgb(232, 232, 232);
            foxButton5.EnabledCalc = true;
            foxButton5.Font = new Font("Segoe UI", 10F);
            foxButton5.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton5.Location = new Point(144, 488);
            foxButton5.Name = "foxButton5";
            foxButton5.OverColor = Color.FromArgb(242, 242, 242);
            foxButton5.RightToLeft = RightToLeft.No;
            foxButton5.Size = new Size(120, 40);
            foxButton5.TabIndex = 8;
            foxButton5.Text = "Hastalık";
            // 
            // foxButton6
            // 
            foxButton6.BackColor = Color.Transparent;
            foxButton6.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton6.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton6.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton6.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton6.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton6.DownColor = Color.FromArgb(232, 232, 232);
            foxButton6.EnabledCalc = true;
            foxButton6.Font = new Font("Segoe UI", 10F);
            foxButton6.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton6.Location = new Point(270, 488);
            foxButton6.Name = "foxButton6";
            foxButton6.OverColor = Color.FromArgb(242, 242, 242);
            foxButton6.RightToLeft = RightToLeft.No;
            foxButton6.Size = new Size(120, 40);
            foxButton6.TabIndex = 8;
            foxButton6.Text = "Hayvan Ekle";
            // 
            // foxButton7
            // 
            foxButton7.BackColor = Color.Transparent;
            foxButton7.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton7.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton7.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton7.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton7.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton7.DownColor = Color.FromArgb(232, 232, 232);
            foxButton7.EnabledCalc = true;
            foxButton7.Font = new Font("Segoe UI", 10F);
            foxButton7.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton7.Location = new Point(396, 488);
            foxButton7.Name = "foxButton7";
            foxButton7.OverColor = Color.FromArgb(242, 242, 242);
            foxButton7.RightToLeft = RightToLeft.No;
            foxButton7.Size = new Size(120, 40);
            foxButton7.TabIndex = 8;
            foxButton7.Text = "Yeni Müşteri";
            foxButton7.Click += foxButton7_Click;
            // 
            // foxButton8
            // 
            foxButton8.BackColor = Color.Transparent;
            foxButton8.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton8.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton8.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton8.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton8.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton8.DownColor = Color.FromArgb(232, 232, 232);
            foxButton8.EnabledCalc = true;
            foxButton8.Font = new Font("Segoe UI", 10F);
            foxButton8.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton8.Location = new Point(12, 534);
            foxButton8.Name = "foxButton8";
            foxButton8.OverColor = Color.FromArgb(242, 242, 242);
            foxButton8.Size = new Size(120, 40);
            foxButton8.TabIndex = 8;
            foxButton8.Text = "Satış İşlemleri";
            // 
            // foxButton10
            // 
            foxButton10.BackColor = Color.Transparent;
            foxButton10.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton10.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton10.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton10.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton10.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton10.DownColor = Color.FromArgb(232, 232, 232);
            foxButton10.EnabledCalc = true;
            foxButton10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            foxButton10.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton10.Location = new Point(144, 534);
            foxButton10.Name = "foxButton10";
            foxButton10.OverColor = Color.FromArgb(242, 242, 242);
            foxButton10.Size = new Size(151, 40);
            foxButton10.TabIndex = 8;
            foxButton10.Text = "Hayvan Bilgileri Düzelt";
            // 
            // foxButton11
            // 
            foxButton11.BackColor = Color.Transparent;
            foxButton11.BaseColor = Color.FromArgb(249, 249, 249);
            foxButton11.BorderColor = Color.FromArgb(193, 193, 193);
            foxButton11.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            foxButton11.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            foxButton11.DisabledTextColor = Color.FromArgb(166, 178, 190);
            foxButton11.DownColor = Color.FromArgb(232, 232, 232);
            foxButton11.EnabledCalc = true;
            foxButton11.Font = new Font("Segoe UI", 10F);
            foxButton11.ForeColor = Color.FromArgb(66, 78, 90);
            foxButton11.Location = new Point(301, 534);
            foxButton11.Name = "foxButton11";
            foxButton11.OverColor = Color.FromArgb(242, 242, 242);
            foxButton11.Size = new Size(147, 40);
            foxButton11.TabIndex = 8;
            foxButton11.Text = "Müşteri Bilgileri Düzelt";
            // 
            // foxBigLabel2
            // 
            foxBigLabel2.BackColor = Color.Transparent;
            foxBigLabel2.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel2.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel2.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel2.Location = new Point(12, 186);
            foxBigLabel2.Name = "foxBigLabel2";
            foxBigLabel2.Size = new Size(524, 41);
            foxBigLabel2.TabIndex = 3;
            foxBigLabel2.Text = "Sahibi Olduğu Hayvanlar";
            // 
            // foxBigLabel3
            // 
            foxBigLabel3.BackColor = Color.Transparent;
            foxBigLabel3.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel3.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel3.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel3.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel3.Location = new Point(12, 435);
            foxBigLabel3.Name = "foxBigLabel3";
            foxBigLabel3.Size = new Size(524, 41);
            foxBigLabel3.TabIndex = 3;
            foxBigLabel3.Text = "İşlemler";
            // 
            // foxTextBox2
            // 
            foxTextBox2.BackColor = Color.Transparent;
            foxTextBox2.EnabledCalc = true;
            foxTextBox2.Font = new Font("Segoe UI", 10F);
            foxTextBox2.ForeColor = Color.FromArgb(66, 78, 90);
            foxTextBox2.Location = new Point(144, 62);
            foxTextBox2.MaxLength = 32767;
            foxTextBox2.MultiLine = false;
            foxTextBox2.Name = "foxTextBox2";
            foxTextBox2.ReadOnly = false;
            foxTextBox2.Size = new Size(179, 32);
            foxTextBox2.TabIndex = 5;
            foxTextBox2.Text = "foxTextBox2";
            foxTextBox2.TextAlign = HorizontalAlignment.Left;
            foxTextBox2.UseSystemPasswordChar = false;
            // 
            // foxTextBox3
            // 
            foxTextBox3.BackColor = Color.Transparent;
            foxTextBox3.EnabledCalc = true;
            foxTextBox3.Font = new Font("Segoe UI", 10F);
            foxTextBox3.ForeColor = Color.FromArgb(66, 78, 90);
            foxTextBox3.Location = new Point(144, 100);
            foxTextBox3.MaxLength = 32767;
            foxTextBox3.MultiLine = false;
            foxTextBox3.Name = "foxTextBox3";
            foxTextBox3.ReadOnly = false;
            foxTextBox3.Size = new Size(179, 32);
            foxTextBox3.TabIndex = 5;
            foxTextBox3.Text = "foxTextBox2";
            foxTextBox3.TextAlign = HorizontalAlignment.Left;
            foxTextBox3.UseSystemPasswordChar = false;
            // 
            // foxTextBox4
            // 
            foxTextBox4.BackColor = Color.Transparent;
            foxTextBox4.EnabledCalc = true;
            foxTextBox4.Font = new Font("Segoe UI", 10F);
            foxTextBox4.ForeColor = Color.FromArgb(66, 78, 90);
            foxTextBox4.Location = new Point(144, 138);
            foxTextBox4.MaxLength = 32767;
            foxTextBox4.MultiLine = false;
            foxTextBox4.Name = "foxTextBox4";
            foxTextBox4.ReadOnly = false;
            foxTextBox4.Size = new Size(179, 32);
            foxTextBox4.TabIndex = 5;
            foxTextBox4.Text = "foxTextBox2";
            foxTextBox4.TextAlign = HorizontalAlignment.Left;
            foxTextBox4.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(foxButton1);
            panel1.Controls.Add(foxTextBox1);
            panel1.Controls.Add(Dgw_OwnerList);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 586);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dgw_ToDoList);
            panel2.Controls.Add(foxBigLabel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(862, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 586);
            panel2.TabIndex = 10;
            // 
            // Dgw_ToDoList
            // 
            Dgw_ToDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgw_ToDoList.Location = new Point(15, 67);
            Dgw_ToDoList.Name = "Dgw_ToDoList";
            Dgw_ToDoList.Size = new Size(299, 507);
            Dgw_ToDoList.TabIndex = 0;
            // 
            // foxBigLabel4
            // 
            foxBigLabel4.BackColor = Color.Transparent;
            foxBigLabel4.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel4.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel4.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel4.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel4.Location = new Point(15, 12);
            foxBigLabel4.Name = "foxBigLabel4";
            foxBigLabel4.Size = new Size(293, 41);
            foxBigLabel4.TabIndex = 3;
            foxBigLabel4.Text = "Yapılacaklar";
            // 
            // panel3
            // 
            panel3.Controls.Add(foxBigLabel1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(foxTextBox2);
            panel3.Controls.Add(foxButton11);
            panel3.Controls.Add(foxTextBox3);
            panel3.Controls.Add(foxButton7);
            panel3.Controls.Add(foxTextBox4);
            panel3.Controls.Add(foxButton10);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(foxButton6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(foxButton8);
            panel3.Controls.Add(foxButton5);
            panel3.Controls.Add(foxBigLabel2);
            panel3.Controls.Add(foxButton4);
            panel3.Controls.Add(Dgw_PatientList);
            panel3.Controls.Add(foxBigLabel3);
            panel3.Controls.Add(foxButton2);
            panel3.Controls.Add(foxButton3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(320, 0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(542, 586);
            panel3.TabIndex = 11;
            // 
            // Operations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 586);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Operations";
            Text = "Operations";
            ((System.ComponentModel.ISupportInitialize)Dgw_OwnerList).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientOwnerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgw_PatientList).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgw_ToDoList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.FoxTextBox foxTextBox1;
        private ReaLTaiizor.Controls.FoxButton foxButton1;
        private DataGridView Dgw_OwnerList;
        private DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private BindingSource patientOwnerBindingSource;
        private BindingSource patientOwnerBindingSource1;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource patientBindingSource;
        private BindingSource patientBindingSource1;
        private BindingSource patientBindingSource2;
        private BindingSource patientBindingSource3;
        private DataGridView Dgw_PatientList;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientGenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BirthDate;
        private ReaLTaiizor.Controls.FoxButton foxButton2;
        private ReaLTaiizor.Controls.FoxButton foxButton3;
        private ReaLTaiizor.Controls.FoxButton foxButton4;
        private ReaLTaiizor.Controls.FoxButton foxButton5;
        private ReaLTaiizor.Controls.FoxButton foxButton6;
        private ReaLTaiizor.Controls.FoxButton foxButton7;
        private ReaLTaiizor.Controls.FoxButton foxButton8;
        private ReaLTaiizor.Controls.FoxButton foxButton10;
        private ReaLTaiizor.Controls.FoxButton foxButton11;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel2;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel3;
        private ReaLTaiizor.Controls.FoxTextBox foxTextBox2;
        private ReaLTaiizor.Controls.FoxTextBox foxTextBox3;
        private ReaLTaiizor.Controls.FoxTextBox foxTextBox4;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Dgw_ToDoList;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel4;
        private Panel panel3;
    }
}