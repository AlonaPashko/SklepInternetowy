
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SklepInternetowy.DAL

{
    public class CoursesContext : DbContext
    {
        public CoursesContext() : base("CourseContext") 
        {

        }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem>OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
