using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Family
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Category { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Genus> Genera { get; set; }
        
        [Property]
        public virtual string Description { get; set; }
    }
}
