using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Models
{
    public class MedicineContext : DbContext
    {
        public MedicineContext(DbContextOptions options) : base(options) { }

        public DbSet<Medicines> Medicine
        {
            get;
            set;
        }
    }
}
