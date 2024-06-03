namespace CalculadoraHistorial;

public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public double Resultado { get { return nuevoValor; } }
    public double ResultadoAnterior { get {  return resultadoAnterior; } set { resultadoAnterior = value; } }
    public TipoOperacion Operation { get { return operacion; } set { operacion = value; } }

    public Operacion(double resultadoAntrerior)
    {
        this.resultadoAnterior = resultadoAntrerior;
        this.nuevoValor = resultadoAntrerior;
    }

    public void Suma(double valor)
    {
        resultadoAnterior = valor;
        nuevoValor += valor;
        operacion = TipoOperacion.Suma;
    }

    public void Resta(double valor)
    {
        resultadoAnterior = valor;
        nuevoValor -= valor;
        operacion = TipoOperacion.Resta;
    }
    
    public void Multiplicar(double valor)
    {
        resultadoAnterior = valor;
        nuevoValor *= valor;
        operacion = TipoOperacion.Multiplicacion;
    }

    public void Dividir(double valor)
    {
        resultadoAnterior = valor;
        nuevoValor /= valor;
        operacion = TipoOperacion.Division;
    }

    public void Limpiar()
    {
        nuevoValor = 0;
        operacion = TipoOperacion.Limpiar;
    }
}