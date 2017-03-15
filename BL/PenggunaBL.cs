using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DAL;

namespace BL
{
    public class PenggunaBL
    {
        public void TambahPengguna(Pengguna pengguna)
        {
            using (PenggunaDAL penggunaDal = new PenggunaDAL())
            {
                try
                {
                    penggunaDal.TambahPengguna(pengguna);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error "+ex.Message);
                }
            }
        }

        public Pengguna LoginPengguna(Pengguna pengguna)
        {
            using (PenggunaDAL penggunaDal = new PenggunaDAL())
            {
                try
                {
                    return penggunaDal.LoginPengguna(pengguna);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
