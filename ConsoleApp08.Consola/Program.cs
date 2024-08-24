namespace ConsoleApp08.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de N: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n<1) 
            {
                Console.WriteLine("Por favor ingrese un numero entero y positivo para N: ");
                return;
            }
            int suma = (n * (n + 1)) / 2;
            Console.WriteLine($"La suma de los primeros {n} números enteros es: {suma}");
        }
    }
}
