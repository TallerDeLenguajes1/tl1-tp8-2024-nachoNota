namespace ListadoTareas;

public class Tareas{
    private int tareaId;
    private string descripcion;
    private int duracion;

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }


    public string Mostrar(){
        
        return "ID: " + TareaId + "|" +
                "Descripcion: " + Descripcion + "|" + 
                "Duracion: " + duracion;
    }


}