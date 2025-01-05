using System.Data;
using System.Data.SQLite;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Interfaces;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class Operations : Form
    {
        public string _connectionString;
        private readonly IServiceProvider serviceProvider;
        private readonly IDatabaseService databaseService;
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepository<PatientOwner> ownerRepository;
        private readonly IDatabaseRepository<Patient> patientRepository;
        private DataTable dataTable;

        public Operations(
            IDatabaseService databaseService,
            IConfiguration configuration,
            IServiceProvider serviceProvider,
            IDatabaseRepository<PatientOwner> ownerRepository,
            IDatabaseRepository<Patient> patientRepository
        )
        {
            databaseService.CreateDatabase();

            this.configuration = configuration;
            this.databaseService = databaseService;
            this.serviceProvider = serviceProvider;
            this.ownerRepository = ownerRepository;
            this.patientRepository = patientRepository;
            _connectionString = configuration.GetConnectionString("DefaultConnection");

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = ownerRepository.GetAll();
            DataView dataView = dt.DefaultView;
            dataView.Sort = "Id DESC";
            Dgw_OwnerList.DataSource = dataView.ToTable();
            Dgw_PatientList.DataSource = patientRepository.GetAll();
            dataTable = dataView.ToTable();
        }

        private void Btn_AddClient_Click(object sender, EventArgs e)
        {
            var ownerAdd = serviceProvider.GetRequiredService<OwnerAdd>();
            ownerAdd.TopMost = true;
            ownerAdd.ShowDialog();
        }

        private void Txt_Search_Enter_1(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "Hasta Sahibi Arama")
            {
                Txt_Search.Text = "";
                Txt_Search.ForeColor = Color.Black;
            }
        }

        private void Txt_Search_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Search.Text))
            {
                Txt_Search.Text = "Hasta Sahibi Arama";
                Txt_Search.ForeColor = Color.Gray;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string filter = Txt_Search.Text.ToLower();
            if (!string.IsNullOrEmpty(Txt_Search.Text))
            {
                if (dataTable is DataTable dt && dt.Rows.Count > 0)
                {
                    var filteredRows = dt.AsEnumerable()
                        .Where(row =>
                            !row.IsNull("OwnerName")
                            && row.Field<string>("OwnerName").ToLower().Contains(filter)
                        );

                    if (filteredRows.Any())
                    {
                        var filteredOwners = filteredRows.CopyToDataTable();
                        Dgw_OwnerList.DataSource = filteredOwners;
                    }
                    else
                    {
                        Dgw_OwnerList.DataSource = dt.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("No data available to filter.");
                }
            }
            else
            {
                LoadData();
            }
        }

        private void Btn_AddPatient_Click(object sender, EventArgs e)
        {
            var patientAdd = serviceProvider.GetRequiredKeyedService<PatientsAdd>;
        }
    }
}
