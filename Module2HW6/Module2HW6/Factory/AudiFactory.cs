namespace Module2HW6
{
    // concrete Factory Audi
    public class AudiFactory : IAbstractVehicleFactory
    {
        public IAMTVehicle CreateAMTVehicle()
        {
            return new AMTVehicle(16000, 17, "Audi", "AMT");
        }

        public ICVTVehicle CreateCVTVehicle()
        {
            return new CVTVehicle(16500, 16, "Audi", "CVT");
        }
    }
}
