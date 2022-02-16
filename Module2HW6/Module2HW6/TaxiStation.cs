namespace Module2HW6
{
    public class TaxiStation
    {
        public TaxiStation(Vehicle[] vehicles)
        {
            if (vehicles == null)
            {
                vehicles = new Vehicle[0];
            }
            else
            {
                Vehicle = vehicles;
            }
        }

        private Vehicle[] Vehicle { get; } = null!;

        public void GetTaxiStationTotaltSum()
        {
            decimal taxiStationTotaltSum = 0;
            foreach (var item in Vehicle)
            {
                taxiStationTotaltSum = taxiStationTotaltSum + item.Price;
            }

            Console.WriteLine($"Total sum of taxi station is {taxiStationTotaltSum} USD.");
        }
    }
}
