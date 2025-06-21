using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard.Utils
{
    public enum TableFieldTypes
    {
        integer,
        nvarchar
    }

    public class TableField
    {
        public string TableFieldValue { get; set; }
        public TableFieldTypes TableFieldType { get; set; }
    }
    public static class DBHelper
    {
            public static void InsertEntry(string tableName, Dictionary<string, TableField> fields)
            {
                var conn = new SqlConnection(Properties.Settings.Default.EmployeesDBConnectionString);
                var fieldsNames = string.Join(",", fields.Select(f => f.Key));
                var fieldsValues = string.Join(",", fields.Select(f =>
                {
                    if (f.Value.TableFieldType == TableFieldTypes.integer)
                    {
                        return f.Value.TableFieldValue;
                    }
                    return $"'{f.Value.TableFieldValue}'";
                }));

                var query = $"INSERT INTO {tableName} ({fieldsNames}) VALUES ({fieldsValues})";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
               
            }
            public static void UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
            {

                var conn = new SqlConnection(Properties.Settings.Default.EmployeesDBConnectionString);
                var updatingFieldsValues = string.Join(", ", fields.Select (f =>
                {
                    var fieldValue = string.Empty;
                    if (f.Value.TableFieldType == TableFieldTypes.integer)
                    {
                        fieldValue = f.Value.TableFieldValue;
                    }
                    else
                    {
                        fieldValue = $"'{f.Value.TableFieldValue}'";
                    }
                    return $"{f.Key} = {fieldValue}";
                }));
                var query = $"UPDATE {tableName} SET {updatingFieldsValues} WHERE Id = {id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
        }

            public static void DeleteEntry(string tableName, int id) 
            {
                var conn = new SqlConnection(Properties.Settings.Default.EmployeesDBConnectionString);
                var query = $"DELETE FROM {tableName} WHERE Id = {id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }


    }
}
