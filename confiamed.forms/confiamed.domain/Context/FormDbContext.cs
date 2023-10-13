using Confiamed.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiamed.Domain.Context
{
    public class FormDbContext:DbContext
    {

        public DbSet<Form> Form {  get; set; }

        public DbSet<FormDetail> FormDetail { get; set; }

        public FormDbContext(DbContextOptions<FormDbContext>options ):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        }
    }
}
