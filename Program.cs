
using CalculadoraHistorial;

var Historial = new List<Operacion>();
double num = 0, actual = 0;
int opcion = 0;

do
{
    Console.WriteLine("----MENU----");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("6- Mostrar historial");
    Console.WriteLine("7- Salir");
    Console.WriteLine("Opcion: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion != 5 && opcion != 6 && opcion != 7)
    {
        Console.WriteLine("Ingrese numero: ");
        num = double.Parse(Console.ReadLine());
    }

    var NuevaOperacion = new Operacion(actual);

    if(opcion != 7) { 
        switch (opcion)
        {
            case 1:
                NuevaOperacion.Suma(num);
                actual = NuevaOperacion.Resultado;
                break;

            case 2:
                NuevaOperacion.Resta(num);
                actual = NuevaOperacion.Resultado;
                break;

            case 3:
                NuevaOperacion.Multiplicar(num);
                actual = NuevaOperacion.Resultado;
                break;

            case 4:
                if (num == 0)
                {
                    Console.WriteLine("No puede realizar la operacion");
                }
                else
                {
                    NuevaOperacion.Dividir(num);
                    actual = NuevaOperacion.Resultado;
                }
                break;

            case 5:
                NuevaOperacion.Limpiar();
                actual = 0;
                break;

            case 6:
                int i = 0;
                foreach (var oper in Historial)
                {
                    Console.WriteLine($"Iteracion: {i}");
                    Console.WriteLine($"Numero ingresado: {oper.ResultadoAnterior}");
                    Console.WriteLine($"Operacion realizada: {oper.Operation}");
                    Console.WriteLine($"Resultado obtenido: {oper.Resultado}");
                    Console.WriteLine("=====================================");
                    i++;
                }
                break;

            default:
                Console.WriteLine("La opcion ingresada no es valida");
                break;
        }
    }

    if (opcion != 6)
    {
        Historial.Add(NuevaOperacion);
    }

} while (opcion != 7);
