using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class StokMap:ClassMap<Stok>
    {
        public StokMap()
        {
            Table("Stok");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.UrunId).Column("UrunId").Not.LazyLoad();
            References(p => p.PersonelId).Column("PersonelId").Not.LazyLoad();
            Map(p => p.Tarih).Column("Tarih");
            Map(p => p.Adet).Column("Adet");
        }
    }
}
