using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAISY_API.Models.DataModel;

namespace DAISY_API.Controllers
{
    public class CounsellorsController : ApiController
    {
        private DAISYEntities db = new DAISYEntities();

        // GET: api/Counsellors
        public IQueryable<Counsellor> GetCounsellors()
        {
            return db.Counsellors;
        }

        // GET: api/Counsellors/5
        [ResponseType(typeof(Counsellor))]
        public IHttpActionResult GetCounsellor(string id)
        {
            Counsellor counsellor = db.Counsellors.Find(id);
            if (counsellor == null)
            {
                return NotFound();
            }

            return Ok(counsellor);
        }

        // PUT: api/Counsellors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCounsellor(string id, Counsellor counsellor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != counsellor.Counsellor1)
            {
                return BadRequest();
            }

            db.Entry(counsellor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounsellorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Counsellors
        [ResponseType(typeof(Counsellor))]
        public IHttpActionResult PostCounsellor(Counsellor counsellor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Counsellors.Add(counsellor);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CounsellorExists(counsellor.Counsellor1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = counsellor.Counsellor1 }, counsellor);
        }

        // DELETE: api/Counsellors/5
        [ResponseType(typeof(Counsellor))]
        public IHttpActionResult DeleteCounsellor(string id)
        {
            Counsellor counsellor = db.Counsellors.Find(id);
            if (counsellor == null)
            {
                return NotFound();
            }

            db.Counsellors.Remove(counsellor);
            db.SaveChanges();

            return Ok(counsellor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CounsellorExists(string id)
        {
            return db.Counsellors.Count(e => e.Counsellor1 == id) > 0;
        }
    }
}