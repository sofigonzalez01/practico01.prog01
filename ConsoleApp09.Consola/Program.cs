namespace ConsoleApp09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculo de distancia entre dos puntos:");
                int coordX1, coordY1, coordX2, coordY2;
                Double distancia;

                Console.Write("ingrese la coordenada de x del punto 1:");
                coordX1 = int.Parse(Console.ReadLine());
                Console.Write("ingrese la coordenada y del punto 1:");
                coordY1 = int.Parse(Console.ReadLine());
                Console.Write("ingrese la coordenada x del punto 2:");
                coordX2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coordenada y del punto 2:");
                coordY2 = int.Parse(Console.ReadLine());

                if (EstanEnLaMismaRecta(coordX1, coordY1, coordX2, coordY2))
                {
                    Console.WriteLine("Los puntos estan en una recta perpendicular");
                }
                else
                    Console.WriteLine("Los puntos pertenecen a distintas rectas");

                distancia = CalcularDistancia(coordX1, coordY1, coordX2, coordY2);

                Console.WriteLine($"La distancia entre los puntos ({coordX1},{coordY1}) y ({coordX2}, {coordY2}) es {distancia}");


            }
            catch (Exception)
            {

                Console.WriteLine("Alguno de los datos fueron mal ingresador");
            }
        }

        private static double CalcularDistancia(int coordX1, int coordY1, int coordX2, int coordY2)
        {
            double distancia = Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2));
            return distancia; 
        }
        /// <summary>
        /// Metodo para ver si dos puntos estan en una recta perpendicular.
        /// </summary>
        /// <param name="coordX1">Coordenada X del primer punto</param>
        /// <param name="coordY1">Coordenada Y del primer punto</param>
        /// <param name="coordX2">Coordenada X del segundo punto</param>
        /// <param name="coordY2">Coordenada Y del segundo punto</param>
        /// <returns>Bool</returns>
        private static bool EstanEnLaMismaRecta(int coordX1, int coordY1, int coordX2, int coordY2)
        {
        //    if(coordX1 == coordX2 || coordY1 == coordY2)
        //    {
        //        return true;
        //    }
        //    return false;
          return coordX1 == coordX2 || coordY1 == coordY2;
        }
    }
}
