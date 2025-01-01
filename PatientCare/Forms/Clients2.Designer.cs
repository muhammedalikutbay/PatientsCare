namespace PatientCare.Forms
{
    partial class Clients2
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
                       System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.DGW_Clients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Add = new Button();
            this.Btn_Delete = new Button();
            this.Btn_Edit = new Button();
            this.Txt_Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Clients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

          this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(322, 185);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(120, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Clients";
       
            this.DGW_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW_Clients.Location = new System.Drawing.Point(0, 0);
            this.DGW_Clients.Name = "DGW_Clients";
            this.DGW_Clients.Size = new System.Drawing.Size(800, 450);
            this.DGW_Clients.TabIndex = 1;

    
            this.Btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(43, 21);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(64, 64);
            this.Btn_Add.TabIndex = 0;

       this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
         this.panel1.Controls.Add(this.Txt_Refresh);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Edit);
            this.panel1.Controls.Add(this.Btn_Add);

                AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGW_Clients);
            this.Controls.Add(this.bigLabel1); FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            this.Name = "Clients";
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.DataGridView DGW_Clients;
        private System.Windows.Forms.Panel panel1;
        private Button Btn_Delete;
        private Button Btn_Add;
        private Button Btn_Edit;
        private Button Txt_Refresh;
    }
}