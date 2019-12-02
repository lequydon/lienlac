using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra.model
{
    class KtraContext:DbContext
    {
        public KtraContext() : base("Data Source=.;Initial Catalog=lienlac;Persist Security Info=True;User ID=sa;password=123")
        {

        }
        public DbSet<lienlac> lienlacs { get; set; }
        public DbSet<nhom> nhoms { get; set; }
    }
}
