namespace Module2HW6
{
    public abstract class Vehicle : IComparable<Vehicle>
    {
        public Vehicle(decimal price, double fuelConsumption)
        {
            Price = price;
            FuelConsumption = fuelConsumption;
        }

        public abstract decimal Price { get; set; }
        public abstract double FuelConsumption { get; set; }

        public int CompareTo(Vehicle? other)
        {
            if (other is null)
            {
                throw new ArgumentException("Сan't compare");
            }

            return FuelConsumption.CompareTo(other.FuelConsumption);
        }

        public abstract void Drive();
    }
}
