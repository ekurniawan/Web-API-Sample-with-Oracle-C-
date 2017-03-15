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
    public class PenggunaDAL : IDisposable
    {
        public void TambahPengguna(Pengguna pengguna)
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"insert into Pengguna(NamaPengguna,SandiPengguna,Aturan) 
                                  values(:NamePengguna,:SandiPengguna,:Aturan)";
                var param = new
                {
                    NamaPengguna = pengguna.NamaPengguna,
                    SandiPengguna = pengguna.SandiPengguna,
                    Aturan = pengguna.Aturan
                };

                try
                {
                    conn.Execute(strSql, param);
                }
                catch (OracleException oraEx)
                {
                    throw new Exception(oraEx.Message);
                }
            }
        }

        public Pengguna LoginPengguna(Pengguna pengguna)
        {
            using (OracleConnection conn = new OracleConnection(GetConnectionString()))
            {
                string strSql = @"select * from Pengguna where NamaPengguna=:NamaPengguna 
                                  and SandiPengguna=:SandiPengguna";
                var param = new
                {
                    NamaPengguna = pengguna.NamaPengguna,
                    SandiPengguna = pengguna.SandiPengguna
                };
                var result = conn.Query<Pengguna>(strSql, param).SingleOrDefault();
                if (result != null)
                    return result;
                else
                    throw new Exception("Error : Username or Password tidak ditemukan");
            }
        }

        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OraConnectionString"].ConnectionString;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
