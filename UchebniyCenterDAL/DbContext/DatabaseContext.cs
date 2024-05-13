using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace EducationCenterDAL
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() :
           base(new SqlConnection()
           {
               ConnectionString = new SqlConnection("Server=DESKTOP-Q5U0TJS\\SQLEXPRESS;Database=EduCenterDb;Trusted_Connection=true;Connect Timeout=900;").ConnectionString
           }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        

        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<TeacherModel> TeacherModels { get; set; }
        public DbSet<GroupModel> GroupModels { get; set; }
    }
}
