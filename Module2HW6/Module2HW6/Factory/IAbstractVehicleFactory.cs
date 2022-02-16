namespace Module2HW6
{
    // abstract factory
    public interface IAbstractVehicleFactory
    {
        IAMTVehicle CreateAMTVehicle();

        ICVTVehicle CreateCVTVehicle();
    }
}
