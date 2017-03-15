using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DAL;

namespace BL
{
    public class DivisiBL
    {
        public IEnumerable<Divisi> GetAllDivisi()
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                return divDal.GetAllDivisi();
            }
        }

        public IEnumerable<Divisi> GetAllByName(string namaDivisi)
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                return divDal.GetAllByName(namaDivisi);
            }
        }

        public Divisi GetByID(int divisiID)
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                return divDal.GetByID(divisiID);
            }
        }

        public void InsertDivisi(Divisi divisi)
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                try
                {
                    divDal.InsertDivisi(divisi);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void UpdateDivisi(Divisi divisi)
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                try
                {
                    divDal.UpdateDivisi(divisi);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void DeleteDivisi(int divisiID)
        {
            using (DivisiDAL divDal = new DivisiDAL())
            {
                try
                {
                    divDal.DeleteDivisi(divisiID);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
