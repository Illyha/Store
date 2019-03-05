namespace DataAccessLayer
{
    public class Concrete
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public virtual Producer Producer { get; set; }
    }
}