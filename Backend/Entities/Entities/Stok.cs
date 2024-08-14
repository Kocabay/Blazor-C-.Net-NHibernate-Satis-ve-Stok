using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Stok:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Urunler UrunId { get; set; }
        public virtual Personel PersonelId { get; set; }
        public virtual DateTime Tarih { get; set; }
        public virtual int Adet { get; set; }
    }
}
