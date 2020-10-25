using System;
using System.Data;

namespace DesignPatterns.Behavioral.Template {
    internal class OleDbDataAdapter {
        private string sql;
        private string connectionString;

        public OleDbDataAdapter(string sql, string connectionString) {
            this.sql = sql;
            this.connectionString = connectionString;
        }

        internal void Fill(DataSet dataSet, string v) {
            //throw new NotImplementedException();
            return;
        }
    }
}