using Microsoft.EntityFrameworkCore;

namespace FinalliziedProject.Databases
{
    class SampleDBContext : DbContext
    {
        private string dbFullPath;

        public SampleDBContext(string dbName)
        {
            dbFullPath = Helper.getCurrentPath() + "\\" + dbName;
            if (!System.IO.File.Exists(dbFullPath))
            {
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {

            optionbuilder.UseSqlite(@"Data Source=" + dbFullPath);
        }

        public DbSet<LibraryPasage> Categories { get; set; }
    }
}
