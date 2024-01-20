namespace FactoryMethod.Vehicles;

public class Motorcycle : IVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos sua encomenda");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando entrega");
    }
}