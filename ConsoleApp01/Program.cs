namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double numero1;
                double numero2;
                double resultadoSuma;

                Console.Write("ingrese el primer valor a sumar: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("ingrese el segundo valor a sumar: ");
                numero2 = double.Parse(Console.ReadLine());

                resultadoSuma = numero1 + numero2;

                Console.WriteLine($"La suma de {numero1} y {numero2} es {resultadoSuma}");

        

            }
            catch (Exception)
            { 
            
                Console.WriteLine("Algo salio mal");

                throw;
            }
    }   }
}
