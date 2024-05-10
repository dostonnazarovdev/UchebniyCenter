﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace EducationCenterDAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"E:\.NET\MyOwnProjects\EduCenterApp\db\eduCenter.db" }.ConnectionString
            }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<MigrantImportModel> MigrantImportModels { get; set; }
        //public DbSet<IchkiIshlarBazaDannix> IchkiIshlarBazaDannixes { get; set; }
    }
}