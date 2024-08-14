using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class KullaniciYetkileri:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Yetkiler YetkiId { get; set; }
        public virtual Personel PersonelId { get; set; }
        public virtual string Password { get; set; }
    }
}
