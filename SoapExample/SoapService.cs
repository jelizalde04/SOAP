using System;
using System.ServiceModel;
using System.Xml.Serialization;

// Definir el contrato del servicio SOAP
[ServiceContract]
public interface ICalculator
{
    [OperationContract]
    int Add(int num1, int num2);

    [OperationContract]
    int Subtract(int num1, int num2);
}

// Implementación del servicio
public class CalculatorService : ICalculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
}
