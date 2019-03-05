using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Country
    {
        public Country()
        {
            Producers = new HashSet<Producer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
    }
}