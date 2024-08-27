using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MusteriMap:ClassMap<Musteri>
    {
        public MusteriMap()
        {
            Table("Musteri");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p=>p.Sehirıd).Column("Sehirıd").Not.LazyLoad();
            Map(p => p.AdiSoyadı).Column("AdiSoyadı");
            Map(p => p.Telefon).Column("Telefon");
            Map(p => p.Adres).Column("Adres").CustomType("text");

        }
    }
}
