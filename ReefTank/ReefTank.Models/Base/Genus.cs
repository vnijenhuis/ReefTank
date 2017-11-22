using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Genus
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [BelongsTo]
        public virtual Family Family { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Creature> Creatures { get; set; }
    }
}
