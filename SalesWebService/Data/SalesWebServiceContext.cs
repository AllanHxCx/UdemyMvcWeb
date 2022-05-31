using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebService.Models;

namespace SalesWebService.Data
{
    public class SalesWebServiceContext : DbContext
    {
        public SalesWebServiceContext (DbContextOptions<SalesWebServiceContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebService.Models.Department>? Department { get; set; }
    }
}
