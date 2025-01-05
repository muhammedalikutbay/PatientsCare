using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Interfaces;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class OwnerAdd : Form
    {
        public string _connectionString;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDatabaseRepository<PatientOwner> ownerRepository;

        public OwnerAdd(
            IServiceProvider serviceProvider,
            IDatabaseRepository<PatientOwner> ownerRepository
        )
        {
            this.Load += new System.EventHandler(this.OwnerAdd_Load);
            _serviceProvider = serviceProvider;
            this.ownerRepository = ownerRepository;
            InitializeComponent();
        }

        private void foxButton1_Click(object sender, EventArgs e)
        {
            PatientOwner patientOwner = new()
            {
                OwnerName = Txt_Name.Text,
                OwnerAdress = Txt_Adress.Text,
                OwnerPhone = Txt_PhoneNo.Text,
            };
            ownerRepository.Insert(patientOwner);

            var operations = _serviceProvider.GetRequiredService<Operations>();
            MessageBox.Show("Veri başarıyla eklendi!");
            operations.LoadData();
            this.Close();
        }

        private void OwnerAdd_Load(object sender, EventArgs e)
        {
            Txt_Name.Clear();
            Txt_Adress.Clear();
            Txt_PhoneNo.Clear();
            this.ActiveControl = Txt_Name;
        }
    }
}
