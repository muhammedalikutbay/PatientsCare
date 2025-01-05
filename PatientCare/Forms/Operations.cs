using System;
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
        private string selectedOwnerId;

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
            dataTable = dataView.ToTable();
            LoadPatientsByOwnerId(selectedOwnerId);
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
            if (!string.IsNullOrEmpty(selectedOwnerId))
            {
                var patientRepository = serviceProvider.GetRequiredService<
                    IDatabaseRepository<Patient>
                >();
                var ownerRepository = serviceProvider.GetRequiredService<
                    IDatabaseRepository<PatientOwner>
                >();
                var patientAdd = new PatientsAdd(
                    configuration,
                    serviceProvider,
                    patientRepository,
                    ownerRepository,
                    selectedOwnerId
                );
                patientAdd.TopMost = true;
                patientAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("İlk önce Hasta Sahibi Seçin.");
            }
        }

        private void LoadPatientsByOwnerId(string ownerId)
        {
            var query = "SELECT * FROM Patient WHERE OwnerId = @OwnerId";

            using var conn = new SQLiteConnection(_connectionString);
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@OwnerId", ownerId);

            var adapter = new SQLiteDataAdapter(cmd);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            Dgw_PatientList.DataSource = dataTable;
        }

        private void Dgw_OwnerList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Dgw_OwnerList.Rows.Count)
            {
                selectedOwnerId = Dgw_OwnerList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                ;
                LoadPatientsByOwnerId(selectedOwnerId);
                LoadOwnerInfoById(selectedOwnerId);
            }
        }

        private void LoadOwnerInfoById(string ownerId)
        {
            var query =
                "SELECT OwnerName, OwnerAdress, OwnerPhone FROM PatientOwner WHERE Id = @OwnerId";

            using var conn = new SQLiteConnection(_connectionString);
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@OwnerId", ownerId);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Txt_Name.Text = reader["OwnerName"].ToString();
                Txt_Adress.Text = reader["OwnerAdress"].ToString();
                Txt_Phone.Text = reader["OwnerPhone"].ToString();
            }
            else
            {
                Txt_Name.Text = string.Empty;
                Txt_Adress.Text = string.Empty;
                Txt_Phone.Text = string.Empty;

                MessageBox.Show("Müşteri bilgileri bulunamadı.");
            }
        }
    }
}
