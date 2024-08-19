namespace ConsoleApp02.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma, resta, producto;
            double division;

            Console.WriteLine("ingrese el primer valor");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo valor");
            numero2= int.Parse(Console.ReadLine());

            suma= numero1+ numero2;
            resta= numero2- numero1;
            producto = numero1* numero2;

            Console.WriteLine ($"la suma es {suma}");
            Console.WriteLine($"la resta es {resta}");
            Console.WriteLine($"El producto es {producto}");
            
            if ( numero1 != 0) 
            {
                division = numero1 / numero1;
                Console.WriteLine($"la division es {division}");
            }
            else
            {
                Console.WriteLine("No es posible dividir por cero");
            }

        }
    }
}
