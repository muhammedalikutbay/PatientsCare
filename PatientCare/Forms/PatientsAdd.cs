using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using PatientCare.Interfaces;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class PatientsAdd : Form
    {
        private readonly IConfiguration configuration;
        public string _connectionString;
        int ownerid;

        public PatientsAdd(IConfiguration configuration,IDatabaseRepository<Patient> databaseRepository )
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            InitializeComponent();
            LoadOwners();
        }

        private void LoadOwners()
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();
            string query = "SELECT Id, OwnerName FROM PatientsOwner";
            SQLiteCommand cmd = new(query, conn);
            SQLiteDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);

            comboBox1.DisplayMember = "OwnerName";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = dt;
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                ownerid = Convert.ToInt32(comboBox1.SelectedValue);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Patient patient = new()
            {
                PatientName = Txt_Name.Text,
                OwnerId = ownerid,
                PatientGender = Txt_Gender.Text,
                RegistrationDate = DateTime.Now.ToString("dd-MM-yyyy"),
                PatientNote = Txt_Note.Text,
            };

            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            string query =
                $"INSERT INTO Patients (PatientName,OwnerId,RegistrationDate,PatientGender,PatientNote) VALUES ('{patient.PatientName}',{patient.OwnerId},'{patient.RegistrationDate}','{patient.PatientGender}','{patient.PatientNote}')";
            using SQLiteCommand cmd = new(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Veri başarıyla eklendi!");
            this.Close();
        }
    }
}
