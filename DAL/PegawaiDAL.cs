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
    public class PegawaiDAL : IDisposable
    {

        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OraConnectionString"].ConnectionString;
        }

        public IEnumerable<Pegawai> GetAllPegawai()
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"select * from Erick.Pegawai left join Erick.Divisi 
                                  on Pegawai.DivisiID = Divisi.DivisiID 
                                  order by Pegawai.NIP asc";

                var results = conn.Query<Pegawai, Divisi, Pegawai>(strSql, (p, d) =>
                {
                    p.Divisi = d;
                    return p;
                }, splitOn: "DivisiID");

                return results;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
