using Castle.ActiveRecord;
using ReefTank.Models.Base;

namespace ReefTank.Models.Corals
{
    [ActiveRecord(Lazy = true, DiscriminatorValue = "Coral")]
    public class Coral : Creature
    {
        [Property]
        public virtual string Difficulty { get; set; }

        [Property]
        public virtual string DifficultyDescription { get; set; }

        [Property]
        public virtual string WaterMovement { get; set; }

        [Property]
        public virtual string Lighting { get; set; }

        [Property]
        public virtual string Fragmenting { get; set; }

        [Property]
        public virtual double MinimumPh { get; set; }

        [Property]
        public virtual double MaximumPh { get; set; }

        public virtual string GetPhRange
        {
            get
            {
                string phValue = $"{MinimumPh} - {MaximumPh}";
                return phValue;
            }
        }

        [Property]
        public virtual int MinimumCalciumPpm { get; set; }

        [Property]
        public virtual int MaximumCalciumPpm { get; set; }

        public virtual string GetCalciumRange
        {
            get
            {
                string phValue = $"{MinimumCalciumPpm} - {MaximumCalciumPpm}";
                return phValue;
            }
        }

        [Property]
        public virtual double MinimumTemperature { get; set; }

        [Property]
        public virtual double MaximumTemperature { get; set; }

        public virtual string GetTemperatureRange
        {
            get
            {
                string phValue = $"{MinimumTemperature}°C - {MaximumTemperature}°C";
                return phValue;
            }
        }
    }
}
