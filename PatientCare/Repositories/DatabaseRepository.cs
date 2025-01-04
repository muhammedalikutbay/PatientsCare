using Microsoft.Extensions.Configuration;
using PatientCare.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;

namespace PatientCare.Repositories
{


public class DatabaseRepository<T> : IDatabaseRepository<T> where T : class, new()
{
    private string _connectionString;

    public DatabaseRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    private string GetTableName()
    {
        return typeof(T).Name; // Tablo adı olarak sınıf adını kullanır
    }

    public DataTable GetAll()
    {
        var tableName = GetTableName();
        using var conn = new SQLiteConnection(_connectionString);
        var query = $"SELECT * FROM {tableName}";
        using var adapter = new SQLiteDataAdapter(query, conn);
        var dataTable = new DataTable();
        adapter.Fill(dataTable);
        return dataTable;
    }

    public void Insert(T entity)
    {
        var tableName = GetTableName();
        var columns = GetColumns();
        var values = GetValues(entity);

        var query = $"INSERT INTO {tableName} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})";
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();
        using var cmd = new SQLiteCommand(query, conn);
        cmd.ExecuteNonQuery();
    }

    public void Update(T entity, string idColumn, object idValue)
    {
        var tableName = GetTableName();
        var updates = GetColumnValuePairs(entity);

        var query = $"UPDATE {tableName} SET {string.Join(", ", updates)} WHERE {idColumn} = @Id";
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();
        using var cmd = new SQLiteCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", idValue);
        cmd.ExecuteNonQuery();
    }

    public void Delete(string idColumn, object idValue)
    {
        var tableName = GetTableName();
        var query = $"DELETE FROM {tableName} WHERE {idColumn} = @Id";
        using var conn = new SQLiteConnection(_connectionString);
        conn.Open();
        using var cmd = new SQLiteCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", idValue);
        cmd.ExecuteNonQuery();
    }

    private IEnumerable<string> GetColumns()
    {
        return typeof(T).GetProperties().Select(p => p.Name);
    }

    private IEnumerable<string> GetValues(T entity)
    {
        return typeof(T).GetProperties().Select(p =>
        {
            var value = p.GetValue(entity);
            return value is string ? $"'{value}'" : value.ToString();
        });
    }

    private IEnumerable<string> GetColumnValuePairs(T entity)
    {
        return typeof(T).GetProperties().Select(p =>
        {
            var value = p.GetValue(entity);
            var formattedValue = value is string ? $"'{value}'" : value.ToString();
            return $"{p.Name} = {formattedValue}";
        });
    }
}

}