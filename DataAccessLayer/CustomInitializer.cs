using System.Data.Entity;

namespace DataAccessLayer
{
    internal class CustomInitializer<T> : DropCreateDatabaseAlways<ConcreteMarket>
    {
        protected override void Seed(ConcreteMarket context)
        {
            var con1 = new Country { Name = "Ukraine" };
            var con2 = new Country { Name = "Poland" };
            var con3 = new Country { Name = "Spain" };
            var con4 = new Country { Name = "France" };

            var pr1 = new Producer
            {
                Name = "Dyckerhoff",
                Country = con1,
            };
            var pr2 = new Producer
            {
                Name = "InterBeton",
                Country = con1,
            };
            var pr3 = new Producer
            {
                Name = "WarshawBeton",
                Country = con2,
            };
            var pr4 = new Producer
            {
                Name = "Poznan'BetonInc",
                Country = con2,
            };
            var pr5 = new Producer
            {
                Name = "AlaParisBeton",
                Country = con3,
            };
            var pr6 = new Producer
            {
                Name = "Shampan'Beton",
                Country = con3,
            };
            var pr7 = new Producer
            {
                Name = "ToreodorBeton",
                Country = con4,
            };
            var pr8 = new Producer
            {
                Name = "SaviliaBeton",
                Country = con4,
            };

            var ctr1 = new Concrete { Mark = "512",Producer=pr1 };
            var ctr2 = new Concrete { Mark = "512", Producer = pr4 };
            var ctr3 = new Concrete { Mark = "512", Producer = pr8 };
            var ctr4 = new Concrete { Mark = "254", Producer = pr1 };
            var ctr5 = new Concrete { Mark = "254", Producer = pr2 };
            var ctr6 = new Concrete { Mark = "254", Producer = pr5 };
            var ctr7 = new Concrete { Mark = "128", Producer = pr1 };
            var ctr8 = new Concrete { Mark = "128", Producer = pr2 };
            var ctr9 = new Concrete { Mark = "128", Producer = pr8 };
            var ctr10 = new Concrete { Mark = "64", Producer = pr2 };
            var ctr11= new Concrete { Mark = "64", Producer = pr6 };
            var ctr12 = new Concrete { Mark = "64", Producer = pr8 };

            context.Concretes.AddRange(new Concrete[] { ctr1,ctr2,ctr3,ctr4,ctr5,ctr6,ctr7,ctr8,ctr9,ctr10,ctr11,ctr12});

            context.SaveChanges();
        }
    }
}