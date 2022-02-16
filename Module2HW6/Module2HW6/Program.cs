namespace Module2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create vehicle
            VehicleClient bmwClient;
            VehicleClient audiClient;
            bmwClient = new VehicleClient(new BMWFactory());
            audiClient = new VehicleClient(new AudiFactory());
            var bmw1 = bmwClient.GetCreatedAMTVihecle();
            var bmw2 = bmwClient.GetCreatedCVTVihecle();
            var audi1 = audiClient.GetCreatedAMTVihecle();
            var audi2 = audiClient.GetCreatedCVTVihecle();
            AutomaticTransmissionVehicle[] cars = new AutomaticTransmissionVehicle[4];
            cars[0] = (AutomaticTransmissionVehicle)bmw1;
            cars[1] = (AutomaticTransmissionVehicle)bmw2;
            cars[2] = (AutomaticTransmissionVehicle)audi1;
            cars[3] = (AutomaticTransmissionVehicle)audi2;

            // add vehicles in taxi station
            TaxiStation taxiStation = new TaxiStation(cars);
            Console.WriteLine("Taxi station composition:");
            foreach (var item in cars)
            {
                item.Print();
            }

            Console.WriteLine();

            // count total sum of taxi station
            taxiStation.GetTaxiStationTotaltSum();
            Console.WriteLine();

            // vehicles sort
            Console.WriteLine("Sort vehicles in the taxi station by fuel consumption:");
            Array.Sort(cars);
            foreach (var item in cars)
            {
                item.Print();
            }

            Console.WriteLine();

            // vehicles search result by criterion
            Console.WriteLine("Search for a vehicle with a given cost:");
            try
            {
                Console.WriteLine();
                Console.WriteLine("1.Search for a vehicle with price - 16000 USD.");
                cars.IsVehiclePrice(16000);
                Console.WriteLine();
                Console.WriteLine("2. Search for a vehicle with price - 5000 USD.");
                cars.IsVehiclePrice(5000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
