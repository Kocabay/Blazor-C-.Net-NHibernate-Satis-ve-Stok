using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class KategoriMap : ClassMap<Kategori>
    {
        public KategoriMap()
        {
            Table("Kategori");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Ad).Column("Ad");
        }
    }
}
