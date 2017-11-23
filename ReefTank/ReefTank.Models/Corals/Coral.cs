using Castle.ActiveRecord;
using ReefTank.Models.Base;

namespace ReefTank.Models.Corals
{
    [ActiveRecord(Lazy = true, DiscriminatorValue = "Coral")]
    public class Coral : Creature
    {
        [Property]
        public virtual CoralType CoralType { get; set; }

        [Property]
        public virtual string Difficulty { get; set; }

        [Property]
        public virtual string DifficultyDescription { get; set; }

        [Property]
        public virtual string WaterMovement { get; set; }

        [Property]
        public virtual string Lighting { get; set; }

        [Property]
        public virtual string Frag { get; set; }

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

    /*
        Degree of Difficulty: Easy to moderate makes this coral great for beginners. They get most nutrients from tank lighting and filter feeding on bacteria.
        Alkalinity: 8° to 10° dKH
        Calcium: 400 - 420 ppm
        Origin: Many places.
        Lighting: They need moderate to bright light.
        Water Movement: Fair to high and turbulent flows.
        Frag: Easy to frag with live rock rubble.
        Warning: There are species of zoanthids that are toxic to humans. Always wear gloves when working with them or being exposed to tank water. Wash thoroughly when you are done.
     */
}
