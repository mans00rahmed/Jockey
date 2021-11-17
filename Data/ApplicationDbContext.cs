using Jockey.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
namespace Jockey.Data

{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
