using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class CountryBll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> ProducersId { get; set; }
    }
}