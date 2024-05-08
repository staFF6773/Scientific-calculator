using System;


class Program
{
  static void Main ()
  {
	while (true)
	  {
		Console.Clear ();
		Console.WriteLine ("Calculadora CientC-fica Avanzada");
		Console.WriteLine ("1. Suma");
		Console.WriteLine ("2. Resta");
		Console.WriteLine ("3. MultiplicaciC3n");
		Console.WriteLine ("4. DivisiC3n");
		Console.WriteLine ("5. Seno");
		Console.WriteLine ("6. Coseno");
		Console.WriteLine ("7. Tangente");
		Console.WriteLine ("8. Arcoseno");
		Console.WriteLine ("9. Arcocoseno");
		Console.WriteLine ("10. Arcotangente");
		Console.WriteLine ("11. Exponencial");
		Console.WriteLine ("12. Logaritmo");
		Console.WriteLine ("13. RaC-z cuadrada");
		Console.WriteLine ("14. Salir");

		Console.Write ("Seleccione una opciC3n: ");
		string opcion = Console.ReadLine ();

		if (opcion == "14")
		  break;

		double resultado = 0;

		switch (opcion)
		  {
		  case "1":

			resultado = OperacionBinaria (Suma);
			break;
			case "2":resultado = OperacionBinaria (Resta);
			break;
			case "3":resultado = OperacionBinaria (Multiplicacion);
			break;
			case "4":resultado = OperacionBinaria (Division);
			break;
			case "5":resultado = OperacionUnaria (Seno);
			break;
			case "6":resultado = OperacionUnaria (Coseno);
			break;
			case "7":resultado = OperacionUnaria (Tangente);
			break;
			case "8":resultado = OperacionUnaria (Arcoseno);
			break;
			case "9":resultado = OperacionUnaria (Arcocoseno);
			break;
			case "10":resultado = OperacionUnaria (Arcotangente);
			break;
			case "11":resultado = OperacionBinaria (Exponencial);
			break;
			case "12":resultado = OperacionBinaria (Logaritmo);
			break;
			case "13":resultado = OperacionUnaria (RaizCuadrada);
			break;
			default:Console.
			  WriteLine ("OpciC3n no vC!lida. IntC)ntelo de nuevo.");
			break;
		  }


		Console.WriteLine ($ "El resultado es: {resultado}");

		Console.WriteLine ("Presione cualquier tecla para continuar...");

		Console.ReadKey ();
	  }

  }


  static double OperacionBinaria (Func < double, double, double >operacion)
  {
	Console.Write ("Ingrese el primer nC:mero: ");
	double num1 = LeerNumero ();

	Console.Write ("Ingrese el segundo nC:mero: ");
	double num2 = LeerNumero ();

	return operacion (num1, num2);
  }


  static double OperacionUnaria (Func < double, double >operacion)
  {
	Console.Write ("Ingrese el nC:mero: ");
	double num = LeerNumero ();

	return operacion (num);
  }


  static double LeerNumero ()
  {
	double num;

	while (!double.TryParse (Console.ReadLine (), out num))
	  {
		Console.WriteLine ("Entrada invC!lida. IntC)ntelo de nuevo.");

	  }
	return num;
  }


  static double Suma (double a, double b)
  {
	return a + b;
  }


  static double Resta (double a, double b)
  {
	return a - b;
  }


  static double Multiplicacion (double a, double b)
  {
	return a * b;
  }


  static double Division (double a, double b)
  {

	if (b != 0)
	  return a / b;
	else
	  {

		Console.WriteLine ("No se puede dividir por cero.");

		return double.NaN;

	  }
  }

  static double Seno (double a)
  {

	return Math.Sin (a);
  }


  static double Coseno (double a)
  {

	return Math.Cos (a);
  }


  static double Tangente (double a)
  {

	return Math.Tan (a);
  }


  static double Arcoseno (double a)
  {

	return Math.Asin (a);
  }


  static double Arcocoseno (double a)
  {

	return Math.Acos (a);
  }


  static double Arcotangente (double a)
  {

	return Math.Atan (a);
  }


  static double Exponencial (double a, double b)
  {

	return Math.Pow (a, b);
  }


  static double Logaritmo (double a, double b)
  {

	return Math.Log (a, b);
  }


  static double RaizCuadrada (double a)
  {

	return Math.Sqrt (a);
  }

}
