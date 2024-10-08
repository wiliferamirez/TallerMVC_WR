using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMVC_WR.Models;

namespace TallerMVC_WR.Data
{
    public class TallerMVC_WRContext : DbContext
    {
        public TallerMVC_WRContext (DbContextOptions<TallerMVC_WRContext> options)
            : base(options)
        {
        }

        public DbSet<TallerMVC_WR.Models.Burger> Burger { get; set; } = default!;
    }
}
