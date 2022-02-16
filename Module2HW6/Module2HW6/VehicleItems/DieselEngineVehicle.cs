namespace Module2HW6
{
    public class DieselEngineVehicle : InternalCombustionVehicle
    {
        public DieselEngineVehicle(decimal price, double fuelConsumption)
            : base(price, fuelConsumption)
        {
        }

        public override decimal Price { get; set; }
        public override double FuelConsumption { get; set; }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("It is diesel engine vehicle.");
        }
    }
}
