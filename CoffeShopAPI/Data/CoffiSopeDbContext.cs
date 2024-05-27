using CoffeShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Menu = CoffeShopAPI.Models.Menu;

namespace CoffeShopAPI.Data
{
    public class CoffiSopeDbContext:DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}