double kilometros;
double yardas, millas;

const double KILOMETRO_A_MILLAS = 0.621371192;
const double KILOMETRO_A_YARDAS = 1093.6133;
const double KILOMETRO_A_METROS = 1000;

Console.WriteLine("Ingrese la distancia en kilometros");

if(!double.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0)
{
    Console.WriteLine("La distancia en kilometros debe ser un numero mayor a cero");
    return;
}
 millas= kilometros*KILOMETRO_A_MILLAS;
yardas = kilometros * KILOMETRO_A_YARDAS;
double metros = kilometros * KILOMETRO_A_METROS;

Console.WriteLine($"Distancia en millas: {millas}");
Console.WriteLine($"Distancia en yardas: {yardas}");
Console.WriteLine($"Distancia en metros: {metros}");






