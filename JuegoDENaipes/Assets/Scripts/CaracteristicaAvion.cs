public class CaracteristicaAvion : Caracteristica
{
    /*
    Esta clase hereda de la clase Caracteristica y define un constructor que invoca al constructor de la clase base pasándole los valores de nombre y valor. 
    También define el método EsMejor() para comparar dos objetos de tipo CaracteristicaAvion. 
    Si el nombre de la característica es "Envergadura", se comparan los valores de la característica actual y la otra característica recibida como parámetro, y se devuelve true si el valor actual es menor que el valor de la otra característica. 
    De lo contrario, se comparan los valores y se devuelve true si el valor actual es mayor que el valor de la otra característica.
    */
    public CaracteristicaAvion(string nombre, int valor) : base(nombre, valor)
    {
    }

    public override bool EsMejor(Caracteristica otraCaracteristica)
    {
        if (Nombre == "Envergadura")
        {
            return Valor < otraCaracteristica.Valor;
        }
        else
        {
            return Valor > otraCaracteristica.Valor;
        }
    }
}
