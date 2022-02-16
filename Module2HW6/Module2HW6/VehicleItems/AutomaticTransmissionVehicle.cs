namespace Module2HW6
{
    public class AutomaticTransmissionVehicle : PetrolEngineVehicle
    {
        public AutomaticTransmissionVehicle(decimal price, double fuelConsumption, string manufacturer, string typeOfAutomTransm)
            : base(price, fuelConsumption)
        {
            Manufacturer = manufacturer;
            TypeOfAutomaticTransmission = typeOfAutomTransm;
        }

        public virtual string Manufacturer { get; set; }
        public virtual string TypeOfAutomaticTransmission { get; set; }
        public override decimal Price { get; set; }
        public override double FuelConsumption { get; set; }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("It is automatic transmission vehicle.");
        }
    }
}
