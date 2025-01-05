using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Interfaces;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class PatientsAdd : Form
    {
        private readonly IConfiguration configuration;
        public string _connectionString;
        private string _selectedOwnerId;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDatabaseRepository<Patient> patientRepository;
        private readonly IDatabaseRepository<PatientOwner> ownerRepository;

        public PatientsAdd(
            IConfiguration configuration,
            IServiceProvider serviceProvider,
            IDatabaseRepository<Patient> patientRepository,
            IDatabaseRepository<PatientOwner> ownerRepository,
            string selectedOwnerId
        )
        {
            this.Load += new System.EventHandler(this.PatientAdd_Load);
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _serviceProvider = serviceProvider;
            InitializeComponent();
            _selectedOwnerId = selectedOwnerId;
            this.patientRepository = patientRepository;
            this.ownerRepository = ownerRepository;
            LoadOwnerInfo();
        }

        private void LoadOwnerInfo()
        {
            string query = "SELECT OwnerName FROM PatientOwner WHERE Id = @Id";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", _selectedOwnerId);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    Lbl_OwnerName.Text = result.ToString();
                }
            }
        }

        private void PatientAdd_Load(object sender, EventArgs e)
        {
            Txt_Name.Clear();
            Txt_Note.Clear();
            this.ActiveControl = Txt_Name;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Patient patient = new()
            {
                OwnerId = Convert.ToInt32(_selectedOwnerId),
                PatientName = Txt_Name.Text,
                PatientGender = Cmb_Gender.Text,
                RegistrationDate = DateTime.Now.ToString("dd-MM-yyyy"),
                BirthDate = Dtp_BirthDate.Text,
                PatientNote = Txt_Note.Text,
            };
            patientRepository.Insert(patient);
            MessageBox.Show("Veri başarıyla eklendi!");
            var operationsForm = _serviceProvider.GetRequiredService<Operations>();
            operationsForm.LoadData();
            this.Close();
        }
    }
}
