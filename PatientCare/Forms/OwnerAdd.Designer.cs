namespace PatientCare.Forms
{
    partial class OwnerAdd
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Txt_Adress = new TextBox();
            Txt_Name = new TextBox();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            Btn_Save = new ReaLTaiizor.Controls.FoxButton();
            Txt_Phone = new TextBox();
            SuspendLayout();
            // 
            // Txt_Adress
            // 
            Txt_Adress.BackColor = SystemColors.ControlLightLight;
            Txt_Adress.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Adress.Location = new Point(188, 118);
            Txt_Adress.Margin = new Padding(4, 3, 4, 3);
            Txt_Adress.Name = "Txt_Adress";
            Txt_Adress.Size = new Size(294, 31);
            Txt_Adress.TabIndex = 25;
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = SystemColors.ControlLightLight;
            Txt_Name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Name.Location = new Point(188, 80);
            Txt_Name.Margin = new Padding(4, 3, 4, 3);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(294, 31);
            Txt_Name.TabIndex = 24;
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(29, 14);
            foxBigLabel1.Margin = new Padding(4, 3, 4, 3);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(302, 47);
            foxBigLabel1.TabIndex = 23;
            foxBigLabel1.Text = "Hasta Sahibi Ekleme";
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel3.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel3.Location = new Point(29, 160);
            foxLabel3.Margin = new Padding(4, 3, 4, 3);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(138, 33);
            foxLabel3.TabIndex = 20;
            foxLabel3.Text = "Telefon No:";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(29, 80);
            foxLabel1.Margin = new Padding(4, 3, 4, 3);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(138, 33);
            foxLabel1.TabIndex = 18;
            foxLabel1.Text = "Adı Soyadı:";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            foxLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel2.Location = new Point(29, 120);
            foxLabel2.Margin = new Padding(4, 3, 4, 3);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(138, 33);
            foxLabel2.TabIndex = 19;
            foxLabel2.Text = "Adresi:";
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
            Btn_Save.Location = new Point(362, 204);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.OverColor = Color.FromArgb(242, 242, 242);
            Btn_Save.Size = new Size(120, 40);
            Btn_Save.TabIndex = 27;
            Btn_Save.Text = "Kaydet";
            Btn_Save.Click += foxButton1_Click;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = SystemColors.ControlLightLight;
            Txt_Phone.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Txt_Phone.Location = new Point(188, 155);
            Txt_Phone.Margin = new Padding(4, 3, 4, 3);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(294, 31);
            Txt_Phone.TabIndex = 25;
            // 
            // OwnerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 278);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_Phone);
            Controls.Add(Txt_Adress);
            Controls.Add(Txt_Name);
            Controls.Add(foxBigLabel1);
            Controls.Add(foxLabel3);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "OwnerAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OwnerAdd";
            Load += OwnerAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.TextBox Txt_Name;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        //private Bunifu.Framework.UI.BunifuTileButton Btn_Add;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxButton Btn_Save;
        private TextBox Txt_Phone;
    }
}