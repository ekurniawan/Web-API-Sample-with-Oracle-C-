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
    public class ViewPegawaiWithDivisiController : ApiController
    {
        // GET: api/ViewPegawaiWithDivisi
        public IEnumerable<ViewPegawaiWithDivisi> Get()
        {
            ViewPegawaiWithDivisiBL viewBL = new ViewPegawaiWithDivisiBL();
            return viewBL.GetAllData();
        }

        // GET: api/ViewPegawaiWithDivisi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ViewPegawaiWithDivisi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ViewPegawaiWithDivisi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ViewPegawaiWithDivisi/5
        public void Delete(int id)
        {
        }
    }
}
