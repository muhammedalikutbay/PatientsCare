namespace PatientCare.Interfaces
{
    public interface IDatabaseService
    {
        void CreateDatabase();
        void CreateTables();
        void InsertSampleData();
    }
}
