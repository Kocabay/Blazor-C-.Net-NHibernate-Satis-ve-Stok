using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class YetkilerMap : ClassMap<Yetkiler>
    {
        public YetkilerMap()
        {
            Table("Yetkiler");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Ad).Column("Ad");
        }
    }
}
