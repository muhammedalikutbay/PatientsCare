using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace PatientCare.Forms
{
    public partial class PatientEdit : Form
    {
        public string _connectionString;
        private readonly IConfiguration configuration;
        public string _patientId;
        private string _selectedOwnerId;

        public PatientEdit(IConfiguration configuration, string patientId, string selectedOwnerId)
        {
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
                            Txt_Name.Text = reader["PatientName"]?.ToString() ?? string.Empty;
                            Cmb_Gender.Text = reader["PatientGender"]?.ToString() ?? string.Empty;
                            Cmb_Type.Text = reader["PatientType"]?.ToString() ?? string.Empty;
                            Dtp_BirthDate.Value =
                                reader["BirthDate"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["BirthDate"])
                                    : DateTime.Now;
                            Txt_Note.Text = reader["PatientNote"]?.ToString() ?? string.Empty;
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

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string updatedName = Txt_Name.Text;
            string updatedGender = Cmb_Gender.Text;
            string updatedType = Cmb_Type.Text;
            string updatedBirthDate = Dtp_BirthDate.Text;
            string updatedNote = Txt_Note.Text;

            using (var conn = new SQLiteConnection(_connectionString))
            {
                string query =
                    "UPDATE Patient SET PatientName = @Name, PatientType = @Type, PatientGender = @Gender, BirthDate = @BirthDate, PatientNote = @Note WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", updatedName);
                    cmd.Parameters.AddWithValue("@Type", updatedType);
                    cmd.Parameters.AddWithValue("@Gender", updatedGender);
                    cmd.Parameters.AddWithValue("@BirthDate", updatedBirthDate);
                    cmd.Parameters.AddWithValue("@Note", updatedNote);
                    cmd.Parameters.AddWithValue("@Id", _patientId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Kayıt güncellenemedi. Lütfen tekrar deneyin.",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            LoadPatientInfo();
            this.Close();
        }


    }
}
