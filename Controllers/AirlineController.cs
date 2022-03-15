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
using Airline.Models;

namespace Airline.Controllers
{
    public class AirlineController : ApiController
    {
        private AirlineModel db = new AirlineModel();

        // GET: api/Airline
        public List<AirlineTable> GetAirlineTables()
        {
            return db.AirlineTables.ToList();
        }

        //// GET: api/Airline/5
        //[ResponseType(typeof(AirlineTable))]
        //public IHttpActionResult GetAirlineTable(int id)
        //{
        //    AirlineTable airlineTable = db.AirlineTables.Find(id);
        //    if (airlineTable == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(airlineTable);
        //}

        //// PUT: api/Airline/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutAirlineTable(int id, AirlineTable airlineTable)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != airlineTable.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(airlineTable).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AirlineTableExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Airline
        //[ResponseType(typeof(AirlineTable))]
        //public IHttpActionResult PostAirlineTable(AirlineTable airlineTable)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.AirlineTables.Add(airlineTable);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = airlineTable.Id }, airlineTable);
        //}

        // DELETE: api/Airline/5
        //[ResponseType(typeof(AirlineTable))]
        //public IHttpActionResult DeleteAirlineTable(int id)
        //{
        //    AirlineTable airlineTable = db.AirlineTables.Find(id);
        //    if (airlineTable == null)
        //    {
        //        return NotFound();
        //    }

        //    db.AirlineTables.Remove(airlineTable);
        //    db.SaveChanges();

        //    return Ok(airlineTable);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool AirlineTableExists(int id)
        //{
        //    return db.AirlineTables.Count(e => e.Id == id) > 0;
        //}
    }
}