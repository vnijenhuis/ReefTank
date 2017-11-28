using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using ReefTank.Core.Domain;

namespace ReefTank.Models.Base
{
    [ActiveRecord(Lazy = true, DiscriminatorColumn = "Type", DiscriminatorType = "string", DiscriminatorLength = "255", DiscriminatorValue = "Creature")]
    public class Creature : IAggregateRoot
    {
        [PrimaryKey(PrimaryKeyType.GuidComb)]
        public virtual Guid Id { get; set; }

        [Property]
        public virtual string CommonName { get; set; }

        [Property(ColumnType = "StringClob", SqlType = "nvarchar(2000)")]
        public virtual string Description { get; set; }

        [BelongsTo]
        public virtual Genus Genus { get; set; }

        [Property]
        public virtual string Species { get; set; }

        [Property]
        public virtual string Origin { get; set; }

        public virtual string ScientificName
        {
            get
            {
                var fullName = Genus.Name;
                fullName += " " + Species;
                return fullName;
            }
        }

        [HasAndBelongsToMany(
            ColumnKey = "CreatureId",  
            ColumnRef = "TagId", 
            Table = "CreatureTag", 
            Cascade = ManyRelationCascadeEnum.SaveUpdate, 
            Lazy = true)]
        public virtual IList<Tag> Tags { get; set; }

        [HasAndBelongsToMany(
            ColumnKey = "CreatureId", 
            ColumnRef = "ReferenceId", 
            Table = "CreatureReference", 
            Cascade = ManyRelationCascadeEnum.SaveUpdate, 
            Lazy = true)]
        public virtual IList<Reference> References { get; set; }
    }
}
