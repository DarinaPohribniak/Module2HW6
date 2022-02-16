namespace Module2HW6
{
    public class VehicleClient
    {
        private IAMTVehicle _amtVehicle;
        private ICVTVehicle _cvtVehicle;

        public VehicleClient(IAbstractVehicleFactory factory)
        {
            _amtVehicle = factory.CreateAMTVehicle();
            _cvtVehicle = factory.CreateCVTVehicle();
        }

        public decimal GetPriceAMTVehicle()
        {
            return _amtVehicle!.GetPrice();
        }

        public decimal GetPriceCVTVehicle()
        {
        return _cvtVehicle!.GetPrice();
        }

        public IAMTVehicle GetCreatedAMTVihecle()
        {
            return _amtVehicle;
        }

        public ICVTVehicle GetCreatedCVTVihecle()
        {
            return _cvtVehicle;
        }
    }
}
