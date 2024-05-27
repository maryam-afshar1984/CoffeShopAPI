using CoffeShopAPI.Data;
using CoffeShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoffeShopAPI.Controllers
{
    public class ReservationsController : ApiController
    {
        CoffiSopeDbContext myDbContext = new CoffiSopeDbContext();

        // POST: api/Quote
        public IHttpActionResult Post( Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            myDbContext.Reservations.Add(reservation);
            myDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
