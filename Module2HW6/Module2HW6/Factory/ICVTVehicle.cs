namespace Module2HW6
{
    // abstract product ICVTVehicle
    public interface ICVTVehicle
    {
        public string GetManufacturer();
        public string GetTypeOfAutomaticTransmission();
        public decimal GetPrice();
        public double GetFuelConsumption();
    }
}
