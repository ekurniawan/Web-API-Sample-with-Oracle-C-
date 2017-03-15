using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BO;
using BL;

namespace SampleAPI.Controllers
{
    public class PegawaiController : ApiController
    {
        // GET: api/Pegawai
        public IEnumerable<Pegawai> Get()
        {
            PegawaiBL pegawaiBL = new PegawaiBL();
            return pegawaiBL.GetAllPegawai();
        }

        // GET: api/Pegawai/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pegawai
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pegawai/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pegawai/5
        public void Delete(int id)
        {
        }
    }
}
