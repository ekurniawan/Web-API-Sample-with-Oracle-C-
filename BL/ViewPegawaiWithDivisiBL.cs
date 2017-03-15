using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DAL;

namespace BL
{
    public class ViewPegawaiWithDivisiBL
    {
        public IEnumerable<ViewPegawaiWithDivisi> GetAllData()
        {
            ViewPegawaiWithDivisiDAL viewDal = new ViewPegawaiWithDivisiDAL();
            return viewDal.GetAllData();
        }
    }
}
