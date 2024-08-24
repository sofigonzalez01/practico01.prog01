namespace ConsoleApp10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoMayor, ladoMenor;
            Console.Write("ingrese el lado mayor del rectangulo: ");
            ladoMayor=int.Parse(Console.ReadLine());
            Console.Write("ingrese el lado menor del rectangulo: ");
            ladoMenor=int.Parse(Console.ReadLine());

            if (ladoMayor>0 && ladoMenor>0)
            {
                double perimetro = 2 * ladoMayor + 2 * ladoMenor;
                double superficie = ladoMayor * ladoMenor;
                double diagonal = Math.Sqrt(Math.Pow(ladoMayor, 2) + Math.Pow(ladoMenor, 2));

                Console.WriteLine($"El rectangulo de lado mayor {ladoMayor} y lado menor {ladoMenor} tiene las siguientes caracteristicas:");
                Console.WriteLine($"Perimetro de: {perimetro}");
                Console.WriteLine($"superficie de: {superficie}");
                Console.WriteLine($"diagonal de: {diagonal:N2}");
            }
            else
            {
                Console.WriteLine("Alguno de los datos esta mal ingresado");
            }
        }
    }
}
