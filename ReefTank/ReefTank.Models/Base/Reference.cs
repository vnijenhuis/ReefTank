using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Reference : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Website { get; set; }

        [Property]
        public virtual string Title { get; set; }

        [Property]
        public virtual string Source { get; set; }

        [Property]
        public virtual DateTime DateLastUpdated { get; set; }

        [HasAndBelongsToMany(
            Table = "CreatureReference", 
            ColumnKey = "ReferenceId", 
            ColumnRef = "CreatureId", 
            Inverse = true, 
            Lazy = true)]
        public virtual IList<Creature> Creatures { get; set; }
    }

    [ActiveRecord(Lazy = true)]
    public class CreatureReference : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.Identity)]
        public virtual int Id { get; set; }

        [BelongsTo]
        public virtual Reference ReferenceId { get; set; }

        [BelongsTo]
        public virtual Creature CreatureId { get; set; }
    }
}
