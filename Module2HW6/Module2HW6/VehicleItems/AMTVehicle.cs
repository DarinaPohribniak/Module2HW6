namespace Module2HW6
{
    public class AMTVehicle : AutomaticTransmissionVehicle, IAMTVehicle
    {
        public AMTVehicle(decimal price, double fuelConsumption, string manufacturer, string typeOfAutomTransm)
            : base(price, fuelConsumption, manufacturer, typeOfAutomTransm)
        {
        }

        public override string Manufacturer { get; set; } = null!;
        public override string TypeOfAutomaticTransmission { get; set; } = null!;
        public override decimal Price { get; set; }
        public override double FuelConsumption { get; set; }
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("It is automatic manual transmission vehicle.");
        }

        public double GetFuelConsumption()
        {
           return FuelConsumption;
        }

        public string GetManufacturer()
        {
            return Manufacturer;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public string GetTypeOfAutomaticTransmission()
        {
           return TypeOfAutomaticTransmission;
        }
    }
}
