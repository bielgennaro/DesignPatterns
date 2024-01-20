namespace FactoryMethod.Vehicles;

public class Bike : IVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos a sua entrega");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Indo ate voce");
    }
}