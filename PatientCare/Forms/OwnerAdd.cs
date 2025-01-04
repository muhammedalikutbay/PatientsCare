using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class OwnerAdd : Form
    {
        private readonly IConfiguration configuration;
        public string _connectionString;
        private readonly IServiceProvider _serviceProvider;


        public OwnerAdd(IConfiguration configuration, IServiceProvider serviceProvider)
        {
            this.configuration = configuration;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void foxButton1_Click(object sender, EventArgs e)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

            PatientOwner patientOwner = new()
            {
                OwnerName = Txt_Name.Text,
                OwnerAdress = Txt_Adress.Text,
                OwnerPhone = Txt_Phone.Text,
            };

            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            string query =
                "INSERT INTO PatientOwner (OwnerName, OwnerAdress, OwnerPhone) VALUES (@OwnerName, @OwnerAdress, @OwnerPhone)";
            using SQLiteCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@OwnerName", patientOwner.OwnerName);
            cmd.Parameters.AddWithValue("@OwnerAdress", patientOwner.OwnerAdress);
            cmd.Parameters.AddWithValue("@OwnerPhone", patientOwner.OwnerPhone);
            cmd.ExecuteNonQuery();
            var operations = _serviceProvider.GetRequiredService<Operations>();
            MessageBox.Show("Veri başarıyla eklendi!");
            operations.LoadData();
            this.Close();
        }

        // Dependency injection ---> Container
    }
}
