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
    public class CallersController : ApiController
    {
        private DAISYEntities db = new DAISYEntities();

        // GET: api/Callers
        public IQueryable<Caller> GetCallers()
        {
            return db.Callers;
        }

        // GET: api/Callers/5
        [ResponseType(typeof(Caller))]
        public IHttpActionResult GetCaller(int id)
        {
            Caller caller = db.Callers.Find(id);
            if (caller == null)
            {
                return NotFound();
            }

            return Ok(caller);
        }

        // PUT: api/Callers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCaller(int id, Caller caller)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != caller.CALLERID)
            {
                return BadRequest();
            }

            db.Entry(caller).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CallerExists(id))
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

        // POST: api/Callers
        [ResponseType(typeof(Caller))]
        public IHttpActionResult PostCaller(Caller caller)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Callers.Add(caller);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = caller.CALLERID }, caller);
        }

        // DELETE: api/Callers/5
        [ResponseType(typeof(Caller))]
        public IHttpActionResult DeleteCaller(int id)
        {
            Caller caller = db.Callers.Find(id);
            if (caller == null)
            {
                return NotFound();
            }

            db.Callers.Remove(caller);
            db.SaveChanges();

            return Ok(caller);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CallerExists(int id)
        {
            return db.Callers.Count(e => e.CALLERID == id) > 0;
        }
    }
}