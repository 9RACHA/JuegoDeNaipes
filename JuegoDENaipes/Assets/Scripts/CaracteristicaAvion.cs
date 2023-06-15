public class CaracteristicaAvion : Caracteristica { //La clase CaracteristicaAvion descenderá de Caracteristica
    /*
    Esta clase hereda de la clase Caracteristica y define un constructor que invoca al constructor de la clase base pasándole los valores de nombre y valor. 
    También define el método EsMejor() para comparar dos objetos de tipo CaracteristicaAvion. 
    Si el nombre de la característica es "Envergadura", se comparan los valores de la característica actual y la otra característica recibida como parámetro, y se devuelve true si el valor actual es menor que el valor de la otra característica. 
    De lo contrario, se comparan los valores y se devuelve true si el valor actual es mayor que el valor de la otra característica.
    */
    /*El constructor de la clase CaracteristicaAvion recibirá como parametros valores para los campos nombre y valor*/
    public CaracteristicaAvion(string nombre, int valor) : base(nombre, valor) //Invocará al constructor de la clase base pasandole esos valores
    { //recibe los parámetros nombre y valor y los pasa al constructor de la clase base utilizando la palabra clave base
    }
    /*La implementacion del metodo EsMejor() comprobará "*/
    public override bool EsMejor(Caracteristica otraCaracteristica)
    {
        if (Nombre == "Envergadura") //si el nombre de la caracteristica es "Envergadura
        {
            //Devolverá el resultado de comparar si el valor del propio objeto Caracteristica es menor
            //que el del objeto caracteristica recibido como parametro
            return Valor < otraCaracteristica.Valor; 
        }
        else //en caso de que el nombre sea otro
        { //Se devolvera el resultado de comparar si el valor del propio objeto Caracteristica es mayor
            return Valor > otraCaracteristica.Valor; //que el del objeto Caracteristica recibido como parametro
        }
        /*Se supondrá que tanto el propio objeto como el objeto recibido como parametro tienen el mismo nombre
        por lo que la comprobacion de este se podrá indistintamente en cualquiera de los 2*/
    }
}
