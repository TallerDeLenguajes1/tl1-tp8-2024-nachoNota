using System.ComponentModel;
using ListadoTareas;

var TareasPendientes = new List<Tareas>();
var TareasRealizadas = new List<Tareas>();

Random rdm = new Random();
int random = rdm.Next(3, 6);

System.Console.WriteLine($"Cantidad de tareas: {random}");

for (int i = 0; i < random; i++)
{
    System.Console.WriteLine("Descripcion: ");
    string descripcion = Console.ReadLine();

    Tareas tarea = new Tareas();
    tarea.TareaId = i;
    tarea.Duracion = rdm.Next(10, 100);
    tarea.Descripcion = descripcion;
    
    TareasPendientes.Add(tarea);
}

int opcion=0;

do
{
    System.Console.WriteLine("----MENU----");
    System.Console.WriteLine("1- Mostrar tareas pendientes");
    System.Console.WriteLine("2- Mostrar tareas realizadas");
    System.Console.WriteLine("3- Marcar pendiente como realizada");
    System.Console.WriteLine("4- Buscar pendiente por descripcion");
    System.Console.WriteLine("Opcion (0 para salir): ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: if(TareasPendientes.Count == 0){
                    System.Console.WriteLine("No existen tareas pendientes");
                } else {
                    foreach (var pend in TareasPendientes)
                    {
                        System.Console.WriteLine(pend.Mostrar());
                    }
                }
            break;
        
        case 2: if(TareasRealizadas.Count == 0){
                    System.Console.WriteLine("No existen tareas realizadas");
                } else {
                    foreach (var real in TareasRealizadas)
                    {
                        System.Console.WriteLine(real.Mostrar());   
                    }
                }
            break;

        case 3: System.Console.WriteLine("Ingrese ID de tarea pendiente a marcar como realizada:");
                int marcarRealiz = int.Parse(Console.ReadLine());
                int i = 0;
                foreach (var pend in TareasPendientes)
                {   
                    if(pend.TareaId == marcarRealiz){
                        TareasRealizadas.Add(TareasPendientes[i]);
                        TareasPendientes.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            break;

        case 4: System.Console.WriteLine("Ingrese palabra a buscar: ");
                string palabra = Console.ReadLine();
                foreach (var pend in TareasPendientes)
                {
                    if(pend.Descripcion.Contains(palabra)){
                        System.Console.WriteLine(pend.Mostrar());
                        break;
                    }
                }
            
            break;

        case 0: break;
        
        default: System.Console.WriteLine("Opcion no valida");
            break;
    }
} while (opcion != 0);


