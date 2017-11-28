using Castle.ActiveRecord;
using ReefTank.Models.Base;

namespace ReefTank.Models.Inhabitants
{
    [ActiveRecord(Lazy = true, DiscriminatorValue = "Inhabitant")]
    public class Inhabitant : Creature
    {
        [Property]
        public virtual double Length { get; set; }

        [Property]
        public virtual double Volume { get; set; }

        [Property]
        public virtual SpecialRequirements SpecialRequirements { get; set; }

        [Property]
        public virtual ReefCompatability ReefCompatability { get; set; }

        [Property]
        public virtual Temperament Temperament { get; set; }

        [Property]
        public virtual string Diet { get; set; }
    }
}