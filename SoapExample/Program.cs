using System.ServiceModel;
class Program
{
    static void Main(string[] args)
    {
        // Configuración del host del servicio
        Uri baseAddress = new Uri("http://localhost:8000/CalculatorService");
        using (ServiceHost host = new ServiceHost(typeof(CalculatorService), baseAddress))
        {
            host.AddServiceEndpoint(typeof(ICalculator), new BasicHttpBinding(), "");
            Console.WriteLine("Servicio SOAP escuchando en: " + baseAddress);
            
            // Abrir el servicio
            host.Open();
            Console.WriteLine("Presiona [Enter] para cerrar el servicio...");
            Console.ReadLine();
        }
    }
}