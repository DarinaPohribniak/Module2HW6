using System.Linq;

namespace Module2HW6
{
    public static class Extension
    {
        public static void IsVehiclePrice(this AutomaticTransmissionVehicle[] vehicles, decimal price)
        {
            int i = 0;
            var gh = new bool[vehicles.Length];
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Price == price)
                {
                    vehicle.Print();
                    vehicle.Drive();
                    gh[i] = true;
                    break;
                }
            }

            if (!gh.Contains(true))
            {
                throw new ArgumentException("There are no vehicles at this price for sale.");
            }
        }

        public static void Print(this AutomaticTransmissionVehicle vehicle)
        {
            Console.WriteLine($"Manufacturer: {vehicle.Manufacturer}; price: {vehicle.Price} USD; " +
                                    $"fuel consumption: {vehicle.FuelConsumption} l.; " +
                                    $"type of automatic transmission: {vehicle.TypeOfAutomaticTransmission}.");
        }
    }
}
