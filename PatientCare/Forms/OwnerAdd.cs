using System;
using System.Data.SQLite;
using System.Windows.Forms;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class OwnerAdd : Form
    {
        public OwnerAdd()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click_1(object sender, EventArgs e)
        {
            PatientOwner patientOwner = new()
            {
                OwnerName = Txt_Name.Text,
                OwnerAdress = Txt_Adress.Text,
                OwnerPhone = Txt_Phone.Text,
            };
            using SQLiteConnection conn = new("Data Source=pf55.db;Version=3;");
            conn.Open();

            string query =
                "INSERT INTO PatientsOwner (OwnerName, OwnerAdress, OwnerPhone) VALUES (@OwnerName, @OwnerAdress, @OwnerPhone)";
            using SQLiteCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@OwnerName", patientOwner.OwnerName);
            cmd.Parameters.AddWithValue("@OwnerAdress", patientOwner.OwnerAdress);
            cmd.Parameters.AddWithValue("@OwnerPhone", patientOwner.OwnerPhone);
            cmd.ExecuteNonQuery();
            Clients clients = new();
            MessageBox.Show("Veri başarıyla eklendi!");
            clients.LoadData();
            this.Close();
            PatientsAdd patientsAdd = new();
            patientsAdd.TopMost = true;
            patientsAdd.Show();
        }
    }
}
