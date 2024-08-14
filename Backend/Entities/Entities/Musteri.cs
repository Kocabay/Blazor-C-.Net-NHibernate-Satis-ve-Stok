using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Musteri :IEntity
    {
        public virtual int Id { get; set; }
        public virtual string AdiSoyadı { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Adres { get; set; }

        public virtual Sehirler Sehirıd {  get; set; }
    }
}
