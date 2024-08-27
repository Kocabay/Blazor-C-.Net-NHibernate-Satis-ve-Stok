using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class KullaniciYetkileriMap:ClassMap<KullaniciYetkileri>
    {
        public KullaniciYetkileriMap()
        {
            Table("KullaniciYetkileri");
            Id(p=>p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Password).Column("Password");
            References(p => p.PersonelId).Column("PersonelId").Not.LazyLoad();
            References(p => p.YetkiId).Column("YetkiId").Not.LazyLoad();

        }
    }
}
