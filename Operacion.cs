namespace CalculadoraHistorial;

public class Operacion{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public Operacion(){
        resultadoAnterior = 0;
        nuevoValor = 0;
        operacion = TipoOperacion.Limpiar;
    }
    
}

public class Calculadora {


    private double dato;
    public double Resultado { get => dato;}
    public void Sumar(double termino){
        dato += termino;
    }

    public void Restar(double termino){
        dato -= termino;
    }

    public void Multiplicar(double termino){
        dato *= termino;
    }

    public void Dividir(double termino){
        dato /= termino;
    }

    public void Limpiar(){
        dato = 0;
    } 
}