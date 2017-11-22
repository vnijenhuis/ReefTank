using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Category
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }
        
        [Property]
        public virtual string Name { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Creature> Creatures { get; set; }
    }
}
