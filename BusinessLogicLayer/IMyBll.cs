using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface IMyBll
    {
        ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark);
        int GetProducersCountByConcreteMark(string concreteMark);
    }
}