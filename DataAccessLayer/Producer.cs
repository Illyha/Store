using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Producer
    {
        public Producer()
        {
            Concretes = new HashSet<Concrete>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Concrete> Concretes { get; set; }
        public virtual Country Country { get; set; }
     

    }
}