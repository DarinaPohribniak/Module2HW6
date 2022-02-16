namespace Module2HW6
{
    public class ElectricMotorVehicle : Vehicle
    {
        public ElectricMotorVehicle(decimal price, double fuelConsumption)
            : base(price, fuelConsumption)
        {
        }

        public override decimal Price { get; set; }
        public override double FuelConsumption { get; set; }

        public override void Drive()
        {
            Console.WriteLine("It is electric motor vehicle.");
        }
    }
}
