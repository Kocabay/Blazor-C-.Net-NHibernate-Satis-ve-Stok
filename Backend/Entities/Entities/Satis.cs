using Base.Entity;

namespace Entities.Entities
{
    public class Satis : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Urunler UrunId { get; set; }
        public virtual Musteri MusteriId { get; set; }
        public virtual DateTime Tarih { get; set; }
        public virtual int Adet { get; set; }
        public virtual Personel PersonelId { get; set; }
    }
}
