using System.ComponentModel.Design;

try
{
	Double resultadoRadianes;
	int valorSexagesimal;
	const double RADIANES = 0.0174532925;


	Console.Write("ingrese el valor en grados sexagesimales: ");
	valorSexagesimal = int.Parse(Console.ReadLine());

	if (valorSexagesimal > 0)
	{

		resultadoRadianes = valorSexagesimal * RADIANES;

		Console.WriteLine($"{valorSexagesimal} en sexagesimales equivale a {resultadoRadianes} radianes");
	}
	else
	{
		Console.WriteLine("valor sexagesimal no encontrado");
	}

}
catch ( FormatException ex)
{

	Console.WriteLine("Numero mal igresado!");
}
catch (OverflowException ex)
{
	Console.WriteLine("Numero demaciado grande!");
}
catch (Exception ex)
{
	Console.WriteLine("Hubo un error, intente nuevamente!");
}
