using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    /// <summary>
    /// The subcategory class is used to categorize marine life by scientific name.
    /// </summary>
    [ActiveRecord(Lazy = true)]
    public class Subcategory : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [BelongsTo]
        public virtual Category Category { get; set; }

        [Property]
        public virtual string Slug { get; set; }

        [Property]
        public virtual string CommonName { get; set; }

        [Property]
        public virtual string ScientificName { get; set; }

        [HasMany(Lazy = true, Cascade = ManyRelationCascadeEnum.All, Inverse = true)]
        public virtual IList<Genus> Genera { get; set; }
        
        [Property(ColumnType = "StringClob", SqlType = "nvarchar(1000)")]
        public virtual string Description { get; set; }
    }
}
