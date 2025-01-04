using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientCare.Interfaces;
using PatientCare.Models;

namespace PatientCare.Forms
{
    public partial class OwnerAdd : Form
    {
        private readonly IConfiguration configuration;
        public string _connectionString;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDatabaseRepository<PatientOwner> ownerRepository;

        public OwnerAdd(
            IConfiguration configuration,
            IServiceProvider serviceProvider,
            IDatabaseRepository<PatientOwner> ownerRepository
        )
        {
            this.configuration = configuration;
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
                OwnerPhone = Txt_Phone.Text,
            };
            ownerRepository.Insert(patientOwner);

            var operations = _serviceProvider.GetRequiredService<Operations>();
            MessageBox.Show("Veri başarıyla eklendi!");
            operations.LoadData();
            this.Close();
        }
    }
}
