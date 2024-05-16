namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle carOne = VehicleFactory.GetVehicle(4);

            IVehicle motoOne = VehicleFactory.GetVehicle(2);

            carOne.Drive();
            motoOne.Drive();
        }
    }
}
