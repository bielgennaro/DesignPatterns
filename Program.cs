using FactoryMethod.Factories;
using Console = System.Console;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "--uber":
                        transport = new CarTransport();
                        break;
                    case "--log":
                        transport = new MotorcycleTransport();
                        break;
                    case "--eats":
                        transport = new BikeTransport();
                        break;
                    default:
                        Console.WriteLine("Selecione o tipo do serviço");
                        break;
                }
            }

            if (transport != null)
            {
                transport.StartTransport();
            }
        }
    }
}