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
    public class DivisiDAL : IDisposable
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OraConnectionString"].ConnectionString;
        }

        public IEnumerable<Divisi> GetAllDivisi()
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"select * from Erick.Divisi order by NamaDivisi asc";
                var results = conn.Query<Divisi>(strSql);
                return results;
            }
        }

        public IEnumerable<Divisi> GetAllByName(string namaDivisi)
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"select * from Erick.Divisi where NamaDivisi like '%' || :NamaDivisi || '%'";
                var results = conn.Query<Divisi>(strSql, new { NamaDivisi = namaDivisi });
                return results;
            }
        }

        public Divisi GetByID(int divisiID)
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"select * from Erick.Divisi where DivisiID=:DivisiID";
                var result = conn.QuerySingleOrDefault<Divisi>(strSql, new { DivisiID = divisiID });
                return result;
            }
        }

        public void InsertDivisi(Divisi divisi)
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"insert into Erick.Divisi(NamaDivisi) values(:NamaDivisi)";
                try
                {
                    conn.Execute(strSql, new { NamaDivisi = divisi.NamaDivisi });
                }
                catch (OracleException oEx)
                {
                    throw new Exception("Error : " + oEx.Message);
                }
            }
        }

        public void UpdateDivisi(Divisi divisi)
        {
            using(OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"update Erick.Divisi set NamaDivisi=:NamaDivisi where DivisiID=:DivisiID";
                try
                {
                    conn.Execute(strSql, 
                        new { NamaDivisi = divisi.NamaDivisi, DivisiID = divisi.DivisiID });
                }
                catch (OracleException oEx)
                {
                    throw new Exception("Error: " + oEx.Message);
                }
            }
        }

        public void DeleteDivisi(int divisiID)
        {
            using(OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"delete from Erick.Divisi where DivisiID=:DivisiID";
                try
                {
                    conn.Execute(strSql, new { DivisiID = divisiID });
                }
                catch (OracleException oEx)
                {
                    throw new Exception("Error :" + oEx.Message);
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
