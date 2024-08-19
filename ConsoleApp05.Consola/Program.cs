using System.Text;

double radio, perimetro, superficie, diametro, longitudDelArco;

Console.Write("Ingrese el valor del radio: ");
radio=Double.Parse(Console.ReadLine());

if (radio>0)
{
    perimetro=2*Math.PI*radio;
    superficie= Math.PI*Math.Pow(radio,2);
    diametro = 2 * radio;
    longitudDelArco = Math.PI * diametro;

    StringBuilder sb = new StringBuilder();
    sb.AppendLine($"Circunferencia de radio: { radio}");
    sb.AppendLine($"Con perimetro: {perimetro}");
    sb.AppendLine($"Con superficie: {superficie}");
    sb.AppendLine($"Con diametro: {diametro}");
    sb.AppendLine($"Con longitud de arco de: {longitudDelArco}");

    Console.WriteLine(sb.ToString());
}
else
{
    Console.WriteLine("Radio no valido");

}
