using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Genus : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [BelongsTo]
        public virtual Subcategory Subcategory { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Creature> Creatures { get; set; }
    }
}
