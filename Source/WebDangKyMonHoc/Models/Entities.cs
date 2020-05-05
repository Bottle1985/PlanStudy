using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace WebDangKyMonHoc.Models
{
    public class Entities : DbContext
    {
        public Entities() : base("StudentManament")
        {
        }
        public DbSet<Student> Students { get; set; }
        //Data Source = Bottle\; Initial Catalog = Student; Integrated Security = True; Pooling=False
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
