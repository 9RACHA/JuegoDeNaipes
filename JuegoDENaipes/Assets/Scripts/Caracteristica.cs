public abstract class Caracteristica
{
    /*
    En esta clase, el campo nombre y valor son privados, lo que significa que sólo se pueden acceder desde la propia clase Caracteristica.
    La propiedad Nombre y Valor son públicas y de sólo lectura, lo que significa que se pueden acceder desde cualquier parte del código, pero no se pueden modificar.
    */
    private string nombre;
    private int valor;

    public string Nombre
    {
        get { return nombre; }
    }

    public int Valor
    {
        get { return valor; }
    }

    /*
    También se define un constructor público que toma los valores para los campos nombre y valor y los asigna a las variables correspondientes.
    Además, se define un método abstracto EsMejor() que tomará un objeto de la clase Caracteristica como parámetro y devolverá un valor booleano.
    La implementación concreta de este método se dejará para las clases derivadas de Caracteristica.
    */
    public Caracteristica(string nombre, int valor)
    {
        this.nombre = nombre;
        this.valor = valor;
    }

    public abstract bool EsMejor(Caracteristica otraCaracteristica);
}

