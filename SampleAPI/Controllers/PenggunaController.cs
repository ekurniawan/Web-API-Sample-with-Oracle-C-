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
    public class PenggunaController : ApiController
    {
        // GET: api/Pengguna
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pengguna/5
        public Pengguna Get(Pengguna pengguna)
        {
            PenggunaBL penggunaBL = new PenggunaBL();
            try
            {
                var result = penggunaBL.LoginPengguna(pengguna);
                if (result != null)
                    return result;
                else
                    return new Pengguna();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // POST: api/Pengguna
        public IHttpActionResult Post(Pengguna pengguna)
        {
            PenggunaBL penggunaBL = new PenggunaBL();
            try
            {
                penggunaBL.TambahPengguna(pengguna);
                return Ok("Data pengguna berhasil ditambah !");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Pengguna/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pengguna/5
        public void Delete(int id)
        {
        }
    }
}
