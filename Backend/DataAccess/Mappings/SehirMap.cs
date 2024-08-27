using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class SehirMap:ClassMap<Sehirler>
    {
        public SehirMap()
        {
            Table("Sehirler");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Ad).Column("Ad");
            Map(p => p.ParentId).Column("ParentId");
        }
    }
}
