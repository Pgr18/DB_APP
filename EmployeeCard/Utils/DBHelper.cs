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
            public static int InsertEntry(string tableName, Dictionary<string, TableField> fields)
            {
                var res = 0;
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

            var selectLastItemQuery = $"SELECT TOP 1 Id FROM {tableName} ORDER BY Id DESC";
            var selectedLastItemCmd = new SqlCommand(selectLastItemQuery, conn);
            conn.Open();
            var reader = selectedLastItemCmd.ExecuteReader();
            while(reader.Read())
            {
                int.TryParse(reader[0].ToString(), out res);

            }
            conn.Close();
            return res;

            }
            public static void UpdateEntry(string tableName, FieldForUpdate fieldForUpdate, Dictionary<string, TableField> fields)
            {

                var conn = new SqlConnection(Properties.Settings.Default.EmployeesDBConnectionString);
                var updatingFieldsValues = string.Join(", ", fields.Select (f
                  => $"{f.Key}={GetFieldValueByType(f.Value)}"));
                var query 
                    = $"UPDATE {tableName} SET {updatingFieldsValues} WHERE {fieldForUpdate.FieldName}= {GetFieldValueByType(fieldForUpdate.FieldValue)}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }


        public static void UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
            => UpdateEntry(tableName, new FieldForUpdate
            {
                FieldName = Constants.FieldsName.Id,
                FieldValue = new TableField
                {
                    TableFieldType = TableFieldTypes.integer,
                    TableFieldValue = id.ToString()
                }
            }, fields);

            public static void DeleteEntry(string tableName, FieldForUpdate fieldForUpdate) 
            {

                var conn = new SqlConnection(Properties.Settings.Default.EmployeesDBConnectionString);
                var query = $"DELETE FROM {tableName} WHERE {fieldForUpdate.FieldName} = {GetFieldValueByType(fieldForUpdate.FieldValue)}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

        public static void DeleteEntry(string tableName, int id)
        
            => DeleteEntry(tableName, new FieldForUpdate
            {
                FieldName = Constants.FieldsName.Id,
                FieldValue = new TableField
                {
                    TableFieldType = TableFieldTypes.integer,
                    TableFieldValue = id.ToString()
                }
            });
        

        private static string GetFieldValueByType(TableField tablefield)
            => tablefield.TableFieldType == TableFieldTypes.integer
            ? tablefield.TableFieldValue : $"'{tablefield.TableFieldValue}'";


        public class FieldForUpdate
        {
            public string FieldName { get; set; }
            public TableField FieldValue { get; set; }
        }
    }
}
