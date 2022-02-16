namespace Module2HW6
{
   // concrete Factory BMV
    public class BMWFactory : IAbstractVehicleFactory
    {
        public IAMTVehicle CreateAMTVehicle()
        {
            return new AMTVehicle(14500, 15, "BMW", "AMT");
        }

        public ICVTVehicle CreateCVTVehicle()
        {
            return new CVTVehicle(15000, 13, "BMW", "CVT");
        }
    }
}
