using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Kategori :IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
    }
}
