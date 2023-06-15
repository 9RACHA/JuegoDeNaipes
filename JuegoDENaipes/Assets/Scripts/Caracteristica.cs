/*La clase Caracteristica debe ser una clase abstracta que servira para representar las caracteristicas de los
objetos representados en los naipes y que serán los que determinen la jugada ganadora. Establecera los campos
y metodos necesarios para manejar la comparacion entre las caracteristicas de dos naipes enfrentados, dejando
los detalles de implementacion para cada caracteristica en particular a las clases derivadas*/
public abstract class Caracteristica
{ //Debe incluir lo siguiente:
    /*
    En esta clase, el campo nombre y valor son privados, lo que significa que sólo se pueden acceder desde la propia clase Caracteristica.
    La propiedad Nombre y Valor son públicas y de sólo lectura, lo que significa que se pueden acceder desde cualquier parte del código, pero no se pueden modificar.
    */
    /*Los 2 campos deben ser accesibles solo a la propia clase Caracteristica y a las que de ella deriven
    El modificador protected permite que los campos sean accesibles por la clase que los declara y por las clases derivadas, pero no por otras clases fuera de la jerarquía de herencia.*/
    protected string nombre; //Un campo de tipo string llamado nombre
     public string Nombre //Una propiedad de tipo string llamada Nombre
    {
        get { //Solo lectura
        return nombre; //Que devolverá el valor del campo nombre 
        } 
    }
    protected int valor; // Un campo de tipo int llamado valor
    public int Valor //Una propiedad de tipo int llamada Valor
    {
        get { return valor; } //Que devolverá el valor del campo nombre
    }
    /*Las 2 propiedades deben ser publicamente accesibles y de solo lectura*/

    /*
    También se define un constructor público que toma los valores para los campos nombre y valor y los asigna a las variables correspondientes.
    Además, se define un método abstracto EsMejor() que tomará un objeto de la clase Caracteristica como parámetro y devolverá un valor booleano.
    La implementación concreta de este método se dejará para las clases derivadas de Caracteristica.
    */
    //Un constructor publico
    public Caracteristica(string nombre, int valor)//que reciba como parametros valores para los campos y valor
    {//Y los asigne a estos campos
        this.nombre = nombre;
        this.valor = valor;
    }
    /*El metodo abstracto EsMejor() que recibira como parametro un objeto de la clase y devolvera un bool*/
    public abstract bool EsMejor(Caracteristica otraCaracteristica);
    //Es abstracto, lo cual indica que no se proporciona una implementación en la clase base y debe ser implementado en las clases derivadas
}

