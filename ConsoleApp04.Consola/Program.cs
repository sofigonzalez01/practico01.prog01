using System.Text;

try
{
	float lado, perimetro;
	Double superficie;

	Console.Write("Ingrese el valor del lado del cuadrado");
	lado = float.Parse(Console.ReadLine());

	if (lado > 0)
	{
		perimetro = lado * 4;
		superficie = Math.Pow(lado, 2);

		StringBuilder sb= new StringBuilder();
		sb.AppendLine($"Cuadrado de lado {lado}");
		sb.AppendLine($"Superficie: {superficie}");
		sb.AppendLine($"Perimetro: {perimetro}");
		
		Console.WriteLine(sb.ToString());
	}
	else
		Console.WriteLine("Valor mal ingresado");
}
catch (Exception ex)
{

	Console.WriteLine("Hubo un error, intente nuevamente");
}

