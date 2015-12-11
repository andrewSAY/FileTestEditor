using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System.Data;

namespace FileTestEditor .Helper {
    public static class DataWorker {

        public static DataTable buildDataTable(string[] columnNames , List<object[]> rows) {
            if (rows .Count != 0) {
                if (columnNames .Count() != rows[0] .Count()) {
                    throw new System .ArgumentException("Количество заголовков колонок должно соответсвоват количеству колонок в строке" , "columnNames");
                }
            }

            DataTable dt = new DataTable();

            foreach (string columnName in columnNames) {
                dt .Columns .Add(columnName);
            }

            foreach (object[] row in rows) {
                dt .Rows .Add(row);
            }            

            return dt;
        }
    }
}
