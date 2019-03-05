using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class MyBll
    {
        private readonly MyDal dal = new MyDal();

        public int GetProducersCountByConcreteMark(string concreteMark)
        {
            return dal.GetProducersCountByConcreteMark(concreteMark);
        }
        public ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark)
        {
            return dal.GetCountriesByConcreteMark(concreteMark)
                .Select(c => new CountryBll
                {
                    Id = c.Id,
                    Name=c.Name,
                    ProducersId=c.Producers.Select(p=>p.Id).ToArray()
                }).ToList();
        }

        public object GetProducersCountByConcreteMark()
        {
            throw new NotImplementedException();
        }
    }
}
