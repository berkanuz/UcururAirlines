using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcururAirline.Entities
{
   public class UcururContext: DbContext
    {
        public UcururContext():base("name=MyConnection")
        {
                
        }
        public DbSet<Sehirler> Sehirler { get; set; }
    }
}
