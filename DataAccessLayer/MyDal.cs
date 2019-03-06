using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class MyDal : IMyDal
    {
        public MyDal(DbContext ctx)
        {
            this.ctx = ctx;
        }
        private readonly DbContext ctx;// = new ConcreteMarket(); 
        public int GetProducersCountByConcreteMark(string concreteMark)
        {
            return ctx.Set<Concrete>()
                .Where(c => c.Mark == concreteMark)//
                .Select(p => p.Producer)//
                .Distinct()
                .Count();
        }

        public ICollection<Country>GetCountriesByConcreteMark(string concreteMark)
        {
            return ctx.Set<Concrete>()
                 .Where(c => c.Mark == concreteMark) //
                 .Select(p => p.Producer.Country)
                 .Distinct().ToList();
                 
        }

    }
}
