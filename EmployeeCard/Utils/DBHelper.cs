using System;
using System.Collections.Generic;
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
            public static bool InsertEntry(string tableName, Dictionary<string, TableField> fields)
            {
                return false;
            }
            public static bool UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
            {
                return false;
            }

            public static bool DeleteEntry(string tableName, int id) 
            { 
                return false; 
            }
    }
}
