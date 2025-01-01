using PatientCare.Interfaces;

namespace PatientCare.Forms
{
    public partial class MainForm : Form
    {
        private readonly IDatabaseService _databaseService;

        public MainForm(IDatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;

            this.Load += new EventHandler(MainForm_Load);
            MainPage mainPage = new();
            LoadFormIntoPanel(mainPage);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _databaseService.CreateDatabase();
        }

        private void LoadFormIntoPanel(Form form)
        {
            pnContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnContent.Controls.Add(form);
            form.Show();
        }

        bool sidebarExpand = true;

        private void SidebarTransiton_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 16;
                if (sidebar.Width <= 128)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 16;
                if (sidebar.Width >= 384)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void BtnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void BtnMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new();
            LoadFormIntoPanel(mainPage);
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            Clients2 clients = new();
            LoadFormIntoPanel(clients);
        }

        private void BtnToDo_Click(object sender, EventArgs e)
        {
            ToDo toDo = new();
            LoadFormIntoPanel(toDo);
        }

        private void BtnCheckList_Click(object sender, EventArgs e)
        {
            CheckList checkList = new();
            LoadFormIntoPanel(checkList);
        }

        private void BtnBalanceSheet_Click(object sender, EventArgs e)
        {
            BalanceSheet balanceSheet = new();
            LoadFormIntoPanel(balanceSheet);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            LoadFormIntoPanel(settings);
        }
    }
}
