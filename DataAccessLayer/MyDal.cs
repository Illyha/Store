using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MyDal
    {
        private readonly ConcreteMarket ctx = new ConcreteMarket(); 
        public int GetProducersCountByConcreteMark(string concreteMark)
        {
            return ctx.Concretes
                .Where(c => c.Mark == concreteMark)//
                .Select(p => p.Producer)//
                .Distinct()
                .Count();
        }

        public ICollection<Country>GetCountriesByConcreteMark(string concreteMark)
        {
            return ctx.Concretes
                 .Where(c => c.Mark == concreteMark) //
                 .Select(p => p.Producer.Country)
                 .Distinct().ToList();
                 
        }


    }
}
