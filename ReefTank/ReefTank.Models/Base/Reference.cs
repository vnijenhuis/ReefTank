using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true)]
    public class Reference
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
            Lazy = true,
            ColumnKey = "Reference",
            ColumnRef = "Inhabitant",
            Table = "InhabitantTags")]
        public virtual IList<Creature> Creatures { get; set; }
    }
}
