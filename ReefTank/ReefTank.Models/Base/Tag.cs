using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Tag
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string Title { get; set; }

        [Property]
        public virtual string Description { get; set; }

        [Property]
        public virtual TagType TagType { get; set; }

        [HasAndBelongsToMany(
            Lazy = true,
            ColumnKey = "Tag",
            ColumnRef = "Inhabitant",
            Table = "InhabitantTags")]
        public virtual IList<Creature> Creatures { get; set; }
    }
}
