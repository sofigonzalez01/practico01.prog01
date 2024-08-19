double kilometros;
double yardas, millas;

const double KILOMETRO_A_MILLAS = 0.621371192;
const double KILOMETRO_A_YARDAS = 1093.6133;
const double KILOMETRO_A_METROS = 1000;

Console.WriteLine("Ingrese la distancia en kilometros");

if (!double.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0)
{
    Console.WriteLine("La distancia en kilometros debe ser un numero mayor a cero");
    return;
}
Console.WriteLine("Seleccione la conversion:");
Console.WriteLine("1.Kilometros a millas");
Console.WriteLine("2.Kilometros a yardas");
Console.WriteLine("3.Kilometros a metros");
Console.Write("Ingrese la opcion seleccionada:");

int opcion;

if(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
{
    Console.WriteLine("opcion no valida");
    return;
}
switch (opcion)
{
    case 1:
        millas = kilometros * KILOMETRO_A_MILLAS;
        Console.WriteLine($"Distancia en millas: {millas}");
        break;
    case 2:
        yardas = kilometros * KILOMETRO_A_YARDAS;
        Console.WriteLine($"Distancia en yardas: {yardas}");
        break;
    case 3:
        double metros = kilometros * KILOMETRO_A_METROS;
        Console.WriteLine($"Distancia en metros: {metros}");
        break;


}




