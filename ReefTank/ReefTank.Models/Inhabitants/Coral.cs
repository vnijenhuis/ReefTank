using System;
using Castle.ActiveRecord;
using ReefTank.Models.Base;

namespace ReefTank.Models.Inhabitants
{
    [ActiveRecord(Lazy = true, DiscriminatorValue = "Coral")]
    public class Coral : Creature
    {
        [Property]
        public virtual Difficulty Difficulty { get; set; }

        [Property]
        public virtual string DifficultyDescription { get; set; }

        [Property]
        public virtual string Lighting { get; set; }

        [Property]
        public virtual string WaterMovement { get; set; }
    }
}
