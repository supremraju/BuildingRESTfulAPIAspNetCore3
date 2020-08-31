using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Repositories
{
    public class WarehouseContext : DbContext

    {

        public WarehouseContext(DbContextOptions<WarehouseContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
