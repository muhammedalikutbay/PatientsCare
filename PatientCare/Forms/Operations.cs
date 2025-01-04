using System.Data;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using PatientCare.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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

        public Operations(IDatabaseService databaseService, IConfiguration configuration, IServiceProvider serviceProvider, IDatabaseRepository<PatientOwner> ownerRepository, IDatabaseRepository<Patient> patientRepository)
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
            Dgw_PatientList.DataSource = patientRepository.GetAll();
            Dgw_OwnerList.DataSource = ownerRepository.GetAll();
        }

        private void foxButton7_Click(object sender, EventArgs e)
        {
            var ownerAdd = serviceProvider.GetRequiredService<OwnerAdd>();
            ownerAdd.TopMost = true;
            ownerAdd.Show();
        }
    }
}
