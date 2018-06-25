namespace WebApiCrecheRepository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CrecheDBContext : DbContext
    {
        public CrecheDBContext()
            : base("name=CrecheDBContext1")
        {
        }

        public virtual DbSet<Creche> Creches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
