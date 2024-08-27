namespace Entities.Entities
{
    public class Sehirler
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual int ParentId { get; set; }
    }
}
