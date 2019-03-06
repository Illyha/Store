using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IMyDal
    {
        ICollection<Country> GetCountriesByConcreteMark(string concreteMark);
        int GetProducersCountByConcreteMark(string concreteMark);
    }
}