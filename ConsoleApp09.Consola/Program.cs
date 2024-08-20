namespace ConsoleApp09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de distancia entre dos puntos:");
            int coordX1, coordY1, coordX2, coordY2;
            Double distancia;

            Console.WriteLine("ingrese la coordenada de x del punto 1:");
            coordX1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada y del punto 1:");
            coordY1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada x del punto 2:");
            coordX2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 2:");
            coordY2 = int.Parse(Console.ReadLine());

            distancia = CalcularDistancia(coordX1, coordY1, coordX2, coordY2);

            Console.WriteLine($"La distancia entre mnn los puntos ({coordX1},{coordY1}) y ({coordX2}, {coordY2}) es {distancia}");


        }

        private static double CalcularDistancia(int coordX1, int coordY1, int coordX2, int coordY2)
        {
            double distancia = Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2));
            return distancia; 
        }
    }
}
