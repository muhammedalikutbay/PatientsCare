using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace PatientCare.Forms
{
    public partial class OwnerEdit : Form
    {
        public string _connectionString;
        private readonly IConfiguration configuration;

        public string OwnerId;

        public OwnerEdit(
            IConfiguration configuration,
            string ownerId,
            string ownerName,
            string ownerPhone,
            string ownerAddress
        )
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

            InitializeComponent();
            OwnerId = ownerId;
            Txt_Name.Text = ownerName;
            Txt_Phone.Text = ownerPhone;
            Txt_Adress.Text = ownerAddress;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string updatedName = Txt_Name.Text;
            string updatedPhone = Txt_Phone.Text;
            string updatedAddress = Txt_Adress.Text;

            using (var conn = new SQLiteConnection(_connectionString))
            {
                string query =
                    "UPDATE PatientOwner SET OwnerName = @OwnerName, OwnerPhone = @OwnerPhone, OwnerAdress = @OwnerAdress WHERE Id = @OwnerId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OwnerName", updatedName);
                    cmd.Parameters.AddWithValue("@OwnerPhone", updatedPhone);
                    cmd.Parameters.AddWithValue("@OwnerAdress", updatedAddress);
                    cmd.Parameters.AddWithValue("@OwnerId", OwnerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla güncellendi!");
                }
            }

            this.Close();
        }
    }
}
