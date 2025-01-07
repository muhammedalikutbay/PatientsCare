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
        private readonly IDatabaseRepository<ToDo> toDoRepository;
        private DataTable dataTable;
        private string selectedOwnerId;
        private string selectedPatientId;

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
            DateTime today = DateTime.Today;
            string todayFormatted = today.ToString("yyyy-MM-dd");
            LoadToDosForDay(todayFormatted);
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
                selectedOwnerId = Dgw_OwnerList.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
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

        private void ClearClientInfos()
        {
            Txt_Name.Clear();
            Txt_Adress.Clear();
            Txt_Phone.Clear();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedOwnerId))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Seçili hasta sahibini silmek istediğinizden emin misiniz?",
                    "Kaydı Sil",
                    MessageBoxButtons.YesNo
                );

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM PatientOwner WHERE Id = @Id";

                    using (var conn = new SQLiteConnection(_connectionString))
                    {
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", selectedOwnerId);

                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Hasta sahibi başarıyla silindi.");
                                LoadData();
                                ClearClientInfos();
                            }
                            else
                            {
                                MessageBox.Show("Hasta sahibi silinemedi.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta sahibi seçin.");
            }
        }

        private void Btn_EditClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedOwnerId))
            {
                string ownerId = selectedOwnerId;
                string ownerName = Txt_Name.Text;
                string ownerPhone = Txt_Phone.Text;
                string ownerAdress = Txt_Adress.Text;

                OwnerEdit ownerEditForm = new OwnerEdit(
                    configuration,
                    ownerId,
                    ownerName,
                    ownerPhone,
                    ownerAdress
                );
                ownerEditForm.ShowDialog();
                LoadData();
                LoadOwnerInfoById(selectedOwnerId);
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta sahibi seçin.");
            }
        }

        private void Operations_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                MessageBox.Show("Tam ekran moduna geçilemez.");
            }
        }

        private void Dgw_PatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Dgw_PatientList.Rows.Count)
            {
                selectedPatientId = Dgw_PatientList.Rows[e.RowIndex].Cells[0].Value?.ToString();
            }
        }

        private void Btn_PatientDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPatientId))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Seçili hayvanı silmek istediğinizden emin misiniz?",
                    "Kaydı Sil",
                    MessageBoxButtons.YesNo
                );

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM Patient WHERE Id = @Id";

                    using (var conn = new SQLiteConnection(_connectionString))
                    {
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", selectedPatientId);

                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Seçili hayvan başarıyla silindi.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Seçili hayvan silinemedi.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
            }
        }

        private void Btn_EditPatient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPatientId))
            {
                string patientId = selectedPatientId;
                string ownerId = selectedOwnerId;

                PatientEdit ownerEditForm = new PatientEdit(configuration, patientId, ownerId);
                ownerEditForm.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
            }
        }

        private void Btn_AddToDo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPatientId))
            {
                string patientId = selectedPatientId;
                string ownerId = selectedOwnerId;
                var toDoAdd = new ToDoAdd(
                    serviceProvider,
                    configuration,
                    selectedPatientId,
                    selectedOwnerId
                );

                toDoAdd.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
            }
        }

        private void LoadToDosForDay(string dayDate)
        {
            string query =
                @"
                SELECT 
                    PatientOwner.OwnerName,
                    Patient.PatientName,
                    ToDo.ToDoName, 
                    ToDo.ToDoDate, 
                    ToDo.ToDoNote 
                FROM 
                    ToDo
                INNER JOIN 
                    Patient ON ToDo.PatientId = Patient.Id
                INNER JOIN 
                    PatientOwner ON ToDo.OwnerId = PatientOwner.Id
                WHERE 
                    ToDo.ToDoDate = @TodayDate";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TodayDate", dayDate);

                    conn.Open();
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dt);

                    Dgw_ToDoList.DataSource = dt;
                    DgwToDoListStyle();
                }
            }
        }

        private void Btn_Today_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_UntilToday_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string todayFormatted = today.ToString("yyyy-MM-dd");

            string query =
                @"
               SELECT 
                    PatientOwner.OwnerName,
                    Patient.PatientName,
                    ToDo.ToDoName, 
                    ToDo.ToDoDate, 
                    ToDo.ToDoNote 
                FROM 
                    ToDo
                INNER JOIN 
                    Patient ON ToDo.PatientId = Patient.Id
                INNER JOIN 
                    PatientOwner ON ToDo.OwnerId = PatientOwner.Id
                WHERE 
                    ToDo.ToDoDate < @Today
                ORDER BY
                    ToDo.Id DESC";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Today", todayFormatted);
                    conn.Open();
                    var adapter = new SQLiteDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Dgw_ToDoList.DataSource = dataTable;
                    DgwToDoListStyle();
                }
            }
        }

        private void Btn_Futures_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string todayFormatted = today.ToString("yyyy-MM-dd");

            string query =
                @"
            SELECT 
                PatientOwner.OwnerName,
                Patient.PatientName, 
                ToDo.ToDoName, 
                ToDo.ToDoDate, 
                ToDo.ToDoNote 
            FROM 
                ToDo
            INNER JOIN 
                Patient ON ToDo.PatientId = Patient.Id
            INNER JOIN 
                PatientOwner ON ToDo.OwnerId = PatientOwner.Id
            WHERE 
                ToDo.ToDoDate > @Today";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Today", todayFormatted);

                    conn.Open();
                    var adapter = new SQLiteDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Dgw_ToDoList.DataSource = dataTable;
                    DgwToDoListStyle();
                }
            }
        }

        private void DgwToDoListStyle()
        {
            Dgw_ToDoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dgw_ToDoList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgw_ToDoList.ColumnHeadersVisible = false;
            Dgw_ToDoList.RowHeadersVisible = false;
        }
    }
}
