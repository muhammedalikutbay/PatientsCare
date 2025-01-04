using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using PatientCare.Interfaces;

namespace PatientCare.Services
{
    internal class DatabaseService(IConfiguration configuration) : IDatabaseService
    {
        private string _connectionString = configuration.GetConnectionString("DefaultConnection");

        public void CreateDatabase()
        {
            this.CreateTables();
        }

        private void CreatePatients()
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            string createTableQuery =
                @"
                      CREATE TABLE IF NOT EXISTS Patient(
                          ""Id""	INTEGER,
	                      ""OwnerId""	INTEGER,
	                      ""PatientName""	TEXT,
	                      ""PatientGender""	TEXT,
	                      ""RegistrationDate""	TEXT,
	                      ""PatientNote""	TEXT,

	                      PRIMARY KEY(""Id""),
	                      FOREIGN KEY(""OwnerId"") REFERENCES ""PatientOwner""(""Id"")
                    );";

            using SQLiteCommand cmd = new(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }

        private void CreatePatientsOwner()
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            string createTableQuery =
                @"
                      CREATE TABLE IF NOT EXISTS PatientOwner(
                            ""Id""	INTEGER,
	                        ""OwnerName""	TEXT,
	                        ""OwnerAdress""	TEXT,
	                        ""OwnerPhone""	INTEGER,

	                        PRIMARY KEY(""Id"")
                    );";

            using SQLiteCommand cmd = new(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }

        private void CreateTreatments()
        {
            using SQLiteConnection conn = new(_connectionString);
            conn.Open();

            string createTableQuery =
                @"
                      CREATE TABLE IF NOT EXISTS Treatment(
	                    ""Id""	INTEGER,
	                    ""PatientId""	INTEGER,
	                    "" TreatmentDate""	DATETIME,
	                    ""Diagnosis""	TEXT,
	                    "" TreatmentDetails""	TEXT,

	                    PRIMARY KEY(""Id""),
	                    FOREIGN KEY(""PatientId"") REFERENCES ""Patient""(""Id"")
                    );";

            using SQLiteCommand cmd = new(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }

        public void CreateTables()
        {
            CreateTreatments();
            CreatePatientsOwner();
            CreatePatients();
        }

        public void InsertSampleData()
        {
            throw new System.NotImplementedException();
        }
    }
}
