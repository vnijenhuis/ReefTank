using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true, DiscriminatorColumn = "Type", DiscriminatorType = "string", DiscriminatorLength = "255", DiscriminatorValue = "Creature")]
    public class Creature
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [BelongsTo]
        public virtual Category Category { get; set; }

        [Property]
        public virtual string Type { get; set; }

        [Property]
        public virtual string CommonName { get; set; }

        [BelongsTo(NotNull = true)]
        public virtual Genus Genus { get; set; }

        [Property(NotNull = true)]
        public virtual string Species { get; set; }

        public virtual string LatinName
        {
            get
            {
                var fullName = Genus.Name;
                fullName += " " + Species;
                return fullName;
            }
        }

        [Property]
        public virtual string Description { get; set; }

        [HasAndBelongsToMany(
            Lazy = true,
            ColumnKey = "Inhabitant",
            ColumnRef = "Tag",
            Table = "InhabitantTags")]
        public virtual IList<Tag> Tags { get; set; }

        [HasAndBelongsToMany(
            Lazy = true,
            ColumnKey = "Inhabitant",
            ColumnRef = "Reference",
            Table = "InhabitantTags")]
        public virtual IList<Reference> References { get; set; }
    }
}
