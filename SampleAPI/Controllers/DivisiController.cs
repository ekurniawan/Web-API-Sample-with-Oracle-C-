using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BO;
using BL;
using System.Diagnostics;

namespace SampleAPI.Controllers
{
    public class DivisiController : ApiController
    {
        private DivisiBL divisiBL = new DivisiBL();
        // GET: api/Divisi
        public IEnumerable<Divisi> Get()
        {
            return divisiBL.GetAllDivisi();
        }

        [Route("api/Divisi/GetAllDivisi")]
        public IEnumerable<Divisi> GetAllDivisi()
        {
            return divisiBL.GetAllDivisi();
        }

        // GET: api/Divisi/5
        public Divisi Get(int id)
        {
            return divisiBL.GetByID(id);
        }

        // POST: api/Divisi
        public IHttpActionResult Post(Divisi divisi)
        {
            try
            {
                divisiBL.InsertDivisi(divisi);
                return Ok();
            }
            catch (Exception ex)
            {
                Debug.Write("Error : " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Divisi/5
        public IHttpActionResult Put(Divisi divisi)
        {
            try
            {
                divisiBL.UpdateDivisi(divisi);
                return Ok();
            }
            catch (Exception ex)
            {
                Debug.Write("Error : " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Divisi/5
        public IHttpActionResult Delete(int divisiID)
        {
            try
            {
                divisiBL.DeleteDivisi(divisiID);
                return Ok();
            }
            catch (Exception ex)
            {
                Debug.Write("Error : " + ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
