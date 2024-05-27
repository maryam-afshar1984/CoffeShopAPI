using CoffeShopAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CoffeShopAPI.Controllers
{
    public class MenusController : ApiController
    {
        CoffiSopeDbContext myDbContext = new CoffiSopeDbContext();

        // GET: Menus
       public IHttpActionResult GetMenus()
        {
            //Eger Loading (Load Menu with Sub1menus)
            var manus = myDbContext.Menus.Include("SubMenus");
            return Ok(manus);
        }

        // GET: Menu/Id
        public IHttpActionResult GetMenu(int id)
        {
            var manu = myDbContext.Menus.Include("SubMenus").FirstOrDefault(m=>m.Id== id);
            if (manu == null)
            {
                return NotFound();
            }
            return Ok(manu);
        }
    }
}