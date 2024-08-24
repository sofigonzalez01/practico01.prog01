
namespace ConsoleApp11.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosFahrenheit;
            Console.WriteLine("Ingrese la temperatura en grados Celcius");
            double gradosCelcius = double.Parse(Console.ReadLine());

            



       
        }

        private static double GradosCelsiusAGradosFahrenheit(double gradosCelcius, double gradosFahrenheit)
        {
            return  1.8 * gradosCelcius + 32;
        }
    }
}
