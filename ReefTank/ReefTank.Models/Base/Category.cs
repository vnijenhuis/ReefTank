using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Category : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }
        
        [Property]
        public virtual string Name { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Subcategory> Subcategories { get; set; }
    }
}
