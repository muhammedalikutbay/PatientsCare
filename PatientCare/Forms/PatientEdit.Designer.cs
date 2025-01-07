namespace PatientCare.Forms
{
    partial class PatientEdit
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
            Cmb_Type = new ComboBox();
            Cmb_Gender = new ComboBox();
            Dtp_BirthDate = new ReaLTaiizor.Controls.PoisonDateTime();
            Btn_Save = new ReaLTaiizor.Controls.FoxButton();
            Txt_Note = new TextBox();
            Txt_Name = new TextBox();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            Lbl_BirthDate = new ReaLTaiizor.Controls.FoxLabel();
            Lbl_Type = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            Lbl_OwnerName = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            SuspendLayout();
            // 
            // Cmb_Type
            // 
            Cmb_Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Cmb_Type.FormattingEnabled = true;
            Cmb_Type.Items.AddRange(new object[] { "Kedi", "Köpek", "Diğer" });
            Cmb_Type.Location = new Point(172, 141);
            Cmb_Type.Name = "Cmb_Type";
            Cmb_Type.Size = new Size(294, 29);
            Cmb_Type.TabIndex = 32;
            // 
            // Cmb_Gender
            // 
            Cmb_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Cmb_Gender.FormattingEnabled = true;
            Cmb_Gender.Items.AddRange(new object[] { "Erkek", "Dişi" });
            Cmb_Gender.Location = new Point(172, 213);
            Cmb_Gender.Name = "Cmb_Gender";
            Cmb_Gender.Size = new Size(294, 29);
            Cmb_Gender.TabIndex = 33;
            // 
            // Dtp_BirthDate
            // 
            Dtp_BirthDate.Location = new Point(172, 176);
            Dtp_BirthDate.MinimumSize = new Size(0, 29);
            Dtp_BirthDate.Name = "Dtp_BirthDate";
            Dtp_BirthDate.Size = new Size(294, 29);
            Dtp_BirthDate.TabIndex = 31;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.Transparent;
            Btn_Save.BaseColor = Color.FromArgb(249, 249, 249);
            Btn_Save.BorderColor = Color.FromArgb(193, 193, 193);
            Btn_Save.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            Btn_Save.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            Btn_Save.DisabledTextColor = Color.FromArgb(166, 178, 190);
            Btn_Save.DownColor = Color.FromArgb(232, 232, 232);
            Btn_Save.EnabledCalc = true;
            Btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_Save.ForeColor = Color.FromArgb(66, 78, 90);
            Btn_Save.Location = new Point(341, 289);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Save.RightToLeft = RightToLeft.Yes;
            Btn_Save.Size = new Size(125, 40);
            Btn_Save.TabIndex = 30;
            Btn_Save.Text = "Kaydet";
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Txt_Note
            // 
            Txt_Note.BackColor = SystemColors.ControlLightLight;
            Txt_Note.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Note.Location = new Point(172, 250);
            Txt_Note.Margin = new Padding(4, 3, 4, 3);
            Txt_Note.Multiline = true;
            Txt_Note.Name = "Txt_Note";
            Txt_Note.Size = new Size(294, 33);
            Txt_Note.TabIndex = 29;
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = SystemColors.ControlLightLight;
            Txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Name.Location = new Point(172, 106);
            Txt_Name.Margin = new Padding(4, 3, 4, 3);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(294, 29);
            Txt_Name.TabIndex = 28;
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(13, 12);
            foxBigLabel1.Margin = new Padding(4, 3, 4, 3);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(453, 47);
            foxBigLabel1.TabIndex = 27;
            foxBigLabel1.Text = "Hasta Bilgileri Düzeltme";
            // 
            // Lbl_BirthDate
            // 
            Lbl_BirthDate.BackColor = Color.Transparent;
            Lbl_BirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Lbl_BirthDate.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_BirthDate.Location = new Point(13, 176);
            Lbl_BirthDate.Margin = new Padding(4, 3, 4, 3);
            Lbl_BirthDate.Name = "Lbl_BirthDate";
            Lbl_BirthDate.Size = new Size(138, 33);
            Lbl_BirthDate.TabIndex = 23;
            Lbl_BirthDate.Text = "Doğum Tarihi:";
            // 
            // Lbl_Type
            // 
            Lbl_Type.BackColor = Color.Transparent;
            Lbl_Type.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Lbl_Type.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_Type.Location = new Point(13, 141);
            Lbl_Type.Margin = new Padding(4, 3, 4, 3);
            Lbl_Type.Name = "Lbl_Type";
            Lbl_Type.Size = new Size(138, 33);
            Lbl_Type.TabIndex = 24;
            Lbl_Type.Text = "Hasta Türü:";
            // 
            // foxLabel5
            // 
            foxLabel5.BackColor = Color.Transparent;
            foxLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel5.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel5.Location = new Point(13, 250);
            foxLabel5.Margin = new Padding(4, 3, 4, 3);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(138, 33);
            foxLabel5.TabIndex = 26;
            foxLabel5.Text = "Hasta Notu:";
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel3.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel3.Location = new Point(13, 213);
            foxLabel3.Margin = new Padding(4, 3, 4, 3);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(138, 33);
            foxLabel3.TabIndex = 25;
            foxLabel3.Text = "Cinsiyet:";
            // 
            // Lbl_OwnerName
            // 
            Lbl_OwnerName.BackColor = Color.Transparent;
            Lbl_OwnerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Lbl_OwnerName.ForeColor = Color.FromArgb(76, 88, 100);
            Lbl_OwnerName.Location = new Point(172, 67);
            Lbl_OwnerName.Margin = new Padding(4, 3, 4, 3);
            Lbl_OwnerName.Name = "Lbl_OwnerName";
            Lbl_OwnerName.Size = new Size(294, 33);
            Lbl_OwnerName.TabIndex = 21;
            Lbl_OwnerName.Text = "Hasta Sahibi";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel2.Location = new Point(13, 67);
            foxLabel2.Margin = new Padding(4, 3, 4, 3);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(138, 33);
            foxLabel2.TabIndex = 22;
            foxLabel2.Text = "Hasta Sahibi:";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(13, 106);
            foxLabel1.Margin = new Padding(4, 3, 4, 3);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(138, 33);
            foxLabel1.TabIndex = 20;
            foxLabel1.Text = "Hasta Adı:";
            // 
            // PatientEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 339);
            Controls.Add(Cmb_Type);
            Controls.Add(Cmb_Gender);
            Controls.Add(Dtp_BirthDate);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_Note);
            Controls.Add(Txt_Name);
            Controls.Add(foxBigLabel1);
            Controls.Add(Lbl_BirthDate);
            Controls.Add(Lbl_Type);
            Controls.Add(foxLabel5);
            Controls.Add(foxLabel3);
            Controls.Add(Lbl_OwnerName);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "PatientEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Cmb_Type;
        private ComboBox Cmb_Gender;
        private ReaLTaiizor.Controls.PoisonDateTime Dtp_BirthDate;
        private ReaLTaiizor.Controls.FoxButton Btn_Save;
        private TextBox Txt_Note;
        private TextBox Txt_Name;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private ReaLTaiizor.Controls.FoxLabel Lbl_BirthDate;
        private ReaLTaiizor.Controls.FoxLabel Lbl_Type;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel Lbl_OwnerName;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
    }
}