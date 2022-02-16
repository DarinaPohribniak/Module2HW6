namespace Module2HW6
{
    // abstract product IAMTVehicle
    public interface IAMTVehicle
    {
        public string GetManufacturer();
        public string GetTypeOfAutomaticTransmission();
        public decimal GetPrice();
        public double GetFuelConsumption();
    }
}
