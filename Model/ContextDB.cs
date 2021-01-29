using System.Data.Entity;

namespace TestSiteApp.Model
{
    class ContextDB : DbContext
    {
        public ContextDB():base("DbConnection")
        {

        }

        public DbSet<Site> Sites { get; set; }
    }
}
