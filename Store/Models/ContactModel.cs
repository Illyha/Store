using BusinessLogicLayer;
using System.Collections.Generic;

namespace Store.Models
{
    public class ContactModel
    {
        public string ConcreteMark { get; set; }
        public IEnumerable<CountryBll> Countries { get; set; }
    }
}