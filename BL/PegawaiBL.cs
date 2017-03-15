using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DAL;

namespace BL
{
    public class PegawaiBL
    {
        public IEnumerable<Pegawai> GetAllPegawai()
        {
            using (PegawaiDAL pegawaiDal = new PegawaiDAL())
            {
                return pegawaiDal.GetAllPegawai();
            }
        }

        public IEnumerable<Pegawai> GetPegawaiByNamaAndDivisi(int divisiID, string namaPegawai)
        {
            using (PegawaiDAL pegawaiDal = new PegawaiDAL())
            {
                return pegawaiDal.GetPegawaiByNamaAndDivisi(divisiID, namaPegawai);
            }
        }
    }
}
