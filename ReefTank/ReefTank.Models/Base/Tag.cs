using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Tag : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Title { get; set; }

        [Property]
        public virtual string Slug { get; set; }

        [Property(ColumnType = "StringClob", SqlType = "nvarchar(400)")]
        public virtual string Description { get; set; }

        [Property]
        public virtual TagType TagType { get; set; }

        [HasAndBelongsToMany(
            ColumnKey = "TagId", 
            ColumnRef = "CreatureId", 
            Table = "CreatureTag", 
            Inverse = true, 
            Lazy = true)]
        public virtual IList<Creature> Creatures { get; set; }
    }

    [ActiveRecord(Lazy = true)]
    public class CreatureTag : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.Identity)]
        public virtual int Id { get; set; }

        [BelongsTo]
        public virtual Tag TagId { get; set; }

        [BelongsTo]
        public virtual Creature CreatureId { get; set; }
    }
}
