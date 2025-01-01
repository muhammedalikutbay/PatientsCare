namespace PatientCare.Forms
{
    partial class MainForm
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

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnMainPage = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnMainPage = new Panel();
            pnClients = new Panel();
            btnClient = new Button();
            pnToDo = new Panel();
            btnToDo = new Button();
            pnCheckList = new Panel();
            btnCheckList = new Button();
            pnBalanceSheet = new Panel();
            btnBalanceSheet = new Button();
            pnSettings = new Panel();
            btnSettings = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnMainPage.SuspendLayout();
            pnClients.SuspendLayout();
            pnToDo.SuspendLayout();
            pnCheckList.SuspendLayout();
            pnBalanceSheet.SuspendLayout();
            pnSettings.SuspendLayout();
            SuspendLayout();
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnMainPage, "btnMainPage");
            btnMainPage.Cursor = Cursors.Hand;
            btnMainPage.ForeColor = SystemColors.ControlText;
            btnMainPage.Name = "btnMainPage";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += BtnMainPage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(nightControlBox1, "nightControlBox1");
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnHam
            // 
            resources.ApplyResources(btnHam, "btnHam");
            btnHam.Name = "btnHam";
            btnHam.TabStop = false;
            btnHam.Click += BtnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Menu;
            sidebar.Controls.Add(pnMainPage);
            sidebar.Controls.Add(pnClients);
            sidebar.Controls.Add(pnToDo);
            sidebar.Controls.Add(pnCheckList);
            sidebar.Controls.Add(pnBalanceSheet);
            sidebar.Controls.Add(pnSettings);
            resources.ApplyResources(sidebar, "sidebar");
            sidebar.ForeColor = Color.FromArgb(192, 255, 255);
            sidebar.Name = "sidebar";
            // 
            // pnMainPage
            // 
            pnMainPage.Controls.Add(btnMainPage);
            resources.ApplyResources(pnMainPage, "pnMainPage");
            pnMainPage.Name = "pnMainPage";
            // 
            // pnClients
            // 
            pnClients.Controls.Add(btnClient);
            resources.ApplyResources(pnClients, "pnClients");
            pnClients.Name = "pnClients";
            // 
            // btnClient
            // 
            btnClient.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnClient, "btnClient");
            btnClient.Cursor = Cursors.Hand;
            btnClient.ForeColor = SystemColors.ControlText;
            btnClient.Name = "btnClient";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += BtnClient_Click;
            // 
            // pnToDo
            // 
            pnToDo.Controls.Add(btnToDo);
            resources.ApplyResources(pnToDo, "pnToDo");
            pnToDo.Name = "pnToDo";
            // 
            // btnToDo
            // 
            btnToDo.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnToDo, "btnToDo");
            btnToDo.Cursor = Cursors.Hand;
            btnToDo.ForeColor = SystemColors.ControlText;
            btnToDo.Name = "btnToDo";
            btnToDo.UseVisualStyleBackColor = false;
            btnToDo.Click += BtnToDo_Click;
            // 
            // pnCheckList
            // 
            pnCheckList.Controls.Add(btnCheckList);
            resources.ApplyResources(pnCheckList, "pnCheckList");
            pnCheckList.Name = "pnCheckList";
            // 
            // btnCheckList
            // 
            btnCheckList.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnCheckList, "btnCheckList");
            btnCheckList.Cursor = Cursors.Hand;
            btnCheckList.ForeColor = SystemColors.ControlText;
            btnCheckList.Name = "btnCheckList";
            btnCheckList.UseVisualStyleBackColor = false;
            btnCheckList.Click += BtnCheckList_Click;
            // 
            // pnBalanceSheet
            // 
            pnBalanceSheet.Controls.Add(btnBalanceSheet);
            resources.ApplyResources(pnBalanceSheet, "pnBalanceSheet");
            pnBalanceSheet.Name = "pnBalanceSheet";
            // 
            // btnBalanceSheet
            // 
            btnBalanceSheet.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnBalanceSheet, "btnBalanceSheet");
            btnBalanceSheet.Cursor = Cursors.Hand;
            btnBalanceSheet.ForeColor = SystemColors.ControlText;
            btnBalanceSheet.Name = "btnBalanceSheet";
            btnBalanceSheet.UseVisualStyleBackColor = false;
            btnBalanceSheet.Click += BtnBalanceSheet_Click;
            // 
            // pnSettings
            // 
            pnSettings.Controls.Add(btnSettings);
            resources.ApplyResources(pnSettings, "pnSettings");
            pnSettings.Name = "pnSettings";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.Menu;
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.ForeColor = SystemColors.ControlText;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += SidebarTransiton_Tick;
            // 
            // pnContent
            // 
            resources.ApplyResources(pnContent, "pnContent");
            pnContent.Name = "pnContent";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ControlBox = false;
            Controls.Add(pnContent);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            ShowIcon = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnMainPage.ResumeLayout(false);
            pnClients.ResumeLayout(false);
            pnToDo.ResumeLayout(false);
            pnCheckList.ResumeLayout(false);
            pnBalanceSheet.ResumeLayout(false);
            pnSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnMainPage;
        private System.Windows.Forms.Panel pnToDo;
        private Button btnToDo;
        private System.Windows.Forms.Panel pnCheckList;
        private Button btnCheckList;
        private System.Windows.Forms.Panel pnSettings;
        private Button btnSettings;
        private System.Windows.Forms.Panel pnBalanceSheet;
        private Button btnBalanceSheet;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnClients;
        private Button btnClient;
        private System.Windows.Forms.Panel pnContent;
    }
}

