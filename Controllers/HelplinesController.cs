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
    public class HelplinesController : ApiController
    {
        private DAISYEntities db = new DAISYEntities();

        // GET: api/Helplines
        public IQueryable<Helpline> GetHelplines()
        {
            return db.Helplines;
        }

        // GET: api/Helplines/5
        [ResponseType(typeof(Helpline))]
        public IHttpActionResult GetHelpline(string id)
        {
            Helpline helpline = db.Helplines.Find(id);
            if (helpline == null)
            {
                return NotFound();
            }

            return Ok(helpline);
        }

        // PUT: api/Helplines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHelpline(string id, Helpline helpline)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != helpline.Helpline1)
            {
                return BadRequest();
            }

            db.Entry(helpline).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HelplineExists(id))
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

        // POST: api/Helplines
        [ResponseType(typeof(Helpline))]
        public IHttpActionResult PostHelpline(Helpline helpline)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Helplines.Add(helpline);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HelplineExists(helpline.Helpline1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = helpline.Helpline1 }, helpline);
        }

        // DELETE: api/Helplines/5
        [ResponseType(typeof(Helpline))]
        public IHttpActionResult DeleteHelpline(string id)
        {
            Helpline helpline = db.Helplines.Find(id);
            if (helpline == null)
            {
                return NotFound();
            }

            db.Helplines.Remove(helpline);
            db.SaveChanges();

            return Ok(helpline);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HelplineExists(string id)
        {
            return db.Helplines.Count(e => e.Helpline1 == id) > 0;
        }
    }
}