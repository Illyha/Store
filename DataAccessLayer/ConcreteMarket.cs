namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ConcreteMarket : DbContext
    {
        
        public ConcreteMarket()
            : base("name=ConcreteMarket")
        {
            Database.SetInitializer<ConcreteMarket>(new CustomInitializer<ConcreteMarket>());
        }
        public virtual DbSet<Concrete> Concretes { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }
}