const double VALOREURO =1053;
const double VALORDOLAR =1360;
const double VALORYUAN =133;

Console.Write("Ingrese la cantidad de dinero en pesos Argentinos:");
double pesos= double.Parse(Console.ReadLine());

if (pesos > 0)
{
    double euro = pesos / VALOREURO;
    double dolar = pesos / VALORDOLAR;
    double yuan = pesos / VALORYUAN;

    Console.WriteLine($"{pesos} ARG equivale en euros:{euro:N2}EUR.");
    Console.WriteLine($"{pesos} ARG equivale en dolares: {dolar:N2} USD.");
    Console.WriteLine($"{pesos} ARG equivale en yuanes: {yuan:N2} CNY.");
}
