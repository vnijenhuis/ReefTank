using Castle.ActiveRecord;
using ReefTank.Models.Base;

namespace ReefTank.Models.Inhabitants
{
    [ActiveRecord(Lazy = true, DiscriminatorValue = "Inhabitant")]
    public class Inhabitant : Creature
    {
        [Property]
        public virtual int Length { get; set; }

        [Property]
        public virtual int Volume { get; set; }

        [Property]
        public virtual Suitability Suitability { get; set; }

        [Property]
        public virtual ReefCompatability ReefCompatability { get; set; }

        [Property]
        public virtual Temperament Temperament { get; set; }

        [Property]
        public virtual Hardiness Hardiness { get; set; }
    }
}