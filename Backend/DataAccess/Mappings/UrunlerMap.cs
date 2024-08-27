using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class UrunlerMap : ClassMap<Urunler>
    {
        public UrunlerMap()
        {
            Table("Urunler");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Ad).Column("Ad");
            References(p=>p.KategoriId).Column("KategoriId").Not.LazyLoad();
            Map(p => p.Tarih).Column("Tarih");
            Map(p => p.Fiyat).Column("Fiyat");

        }
    }
}
