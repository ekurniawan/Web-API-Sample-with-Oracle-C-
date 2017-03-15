using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using BO;
using Dapper;

namespace DAL
{
    public class ViewPegawaiWithDivisiDAL
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OraConnectionString"].ConnectionString;
        }

        public IEnumerable<ViewPegawaiWithDivisi> GetAllData()
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = "select * from Erick.ViewPegawaiWithDivisi";
                var results = conn.Query<ViewPegawaiWithDivisi>(strSql);
                return results;
            }
        }
    }
}
