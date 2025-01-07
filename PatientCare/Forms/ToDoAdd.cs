using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PatientCare.Forms
{
    public partial class ToDoAdd : Form
    {
        public string _connectionString;
        private readonly IConfiguration configuration;
        public string _patientId;
        private string _selectedOwnerId;
        private readonly IServiceProvider _serviceProvider;

        public ToDoAdd(
            IServiceProvider serviceProvider,
            IConfiguration configuration,
            string patientId,
            string selectedOwnerId
        )
        {
            _serviceProvider = serviceProvider;
            _patientId = patientId;
            _selectedOwnerId = selectedOwnerId;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            InitializeComponent();
            LoadPatientInfo();
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
                    if (result != null)
                    {
                        Lbl_OwnerName.Text = result.ToString();
                    }
                    else
                    {
                        Lbl_OwnerName.Text = "Bilgi bulunamadı";
                    }
                }
            }
        }

        private void LoadPatientInfo()
        {
            string query = "SELECT * FROM Patient WHERE Id = @Id";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", _patientId);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Lbl_Name.Text = reader["PatientName"]?.ToString() ?? string.Empty;
                            Lbl_Gender.Text = reader["PatientGender"]?.ToString() ?? string.Empty;
                            Lbl_Type.Text = reader["PatientType"]?.ToString() ?? string.Empty;
                            Lbl_BirthDate.Text = reader["BirthDate"]?.ToString() ?? string.Empty;
                            Lbl_Note.Text = reader["PatientNote"]?.ToString() ?? string.Empty;
                        }
                        else
                        {
                            MessageBox.Show(
                                "Hasta bilgisi bulunamadı.",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
        }

        private void Btn_AddToDo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Dose.Text, out int dose) || dose <= 0)
            {
                MessageBox.Show("Geçerli bir doz değeri girin!");
                return;
            }

            if (!int.TryParse(Txt_Range.Text, out int range) || range <= 0)
            {
                MessageBox.Show("Geçerli bir gün aralığı girin!");
                return;
            }

            string query =
                "INSERT INTO ToDo (OwnerId, PatientId, ToDoName, ToDoDate, ToDoNote) VALUES (@OwnerId, @PatientId, @ToDoName, @ToDoDate, @ToDoNote)";

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                for (int i = 0; i < dose; i++)
                {
                    var toDoDate = Dtp_Date.Value.AddDays(i * range).ToString("yyyy-MM-dd");

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OwnerId", Convert.ToInt32(_selectedOwnerId));
                        cmd.Parameters.AddWithValue("@PatientId", Convert.ToInt32(_patientId));
                        cmd.Parameters.AddWithValue("@ToDoName", Txt_Name.Text);
                        cmd.Parameters.AddWithValue("@ToDoDate", toDoDate);
                        cmd.Parameters.AddWithValue("@ToDoNote", Txt_Note.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Yapılacak başarıyla eklendi!");
            }
        }

        private void ToDoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            var operations = _serviceProvider.GetRequiredService<Operations>();
            operations.LoadData();
        }
    }
}
