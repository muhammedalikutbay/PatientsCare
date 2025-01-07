using System.Data;

namespace PatientCare.Interfaces
{
    public interface IDatabaseRepository<T>
        where T : class, new()
    {
        DataTable GetAll();
        void Insert(T entity);
        void Update(T entity, string idColumn, object idValue);
        void Delete(string idColumn, object idValue);
    }
}
