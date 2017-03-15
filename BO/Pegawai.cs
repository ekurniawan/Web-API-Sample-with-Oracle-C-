using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Pegawai
    {
        public string NIP { get; set; }
        public int DivisiID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }

        public Divisi Divisi { get; set; }
    }
}
