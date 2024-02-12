using DataAccess_Layer.Entries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Data
{
    public class ApplicationDbConext : DbContext
    {
        public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

}
