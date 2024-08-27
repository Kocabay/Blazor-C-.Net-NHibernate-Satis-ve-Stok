using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class PersonelMap : ClassMap<Personel>
    {
        public PersonelMap()
        {
            Table("Personel");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.AdiSoyadı).Column("AdiSoyadı");
            Map(p => p.Adresi).Column("Adresi").CustomSqlType("text");
            Map(p => p.Mail).Column("Mail");
            Map(p => p.Telefon).Column("Telefon");
        }
    }
}
