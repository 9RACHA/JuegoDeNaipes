using System.Collections.Generic; //NECESARIO PARA AÑADIR LIST

public class Naipe
{
    /*
    La clase Naipe tiene los campos nombre, palo y caracteristicas. 
    Los dos primeros son de tipo string y se pueden acceder a través de las propiedades Nombre y Palo, respectivamente. 
    El campo caracteristicas es de tipo List<Caracteristica>, es decir, una lista de objetos de tipo Caracteristica.
    */

    private string nombre; //Un campo de tipo string llamado nombre
    /*Un campo es una variable que almacena datos en una clase,
    una propiedad proporciona un acceso controlado a un campo y permite aplicar lógica adicional al leer o escribir el valor del campo*/
    public string Nombre => nombre; //Una propiedad de tipo string llamada Nombre que devolvera el valor de campo nombre;
    private string palo; //Un campo privado de tipo string llamado palo;
    public string Palo => palo; //Una propiedad de tipo string llamada Palo que devolvera el valor del campo palo

    //Los dos campos deben ser accesibles solo a la propia clase Naipe: por eso son PRIVATE
    /*Las dos propiedades deben ser publicamente accesibles y de solo lectura: declararlas como propiedades públicas con solo el bloque get.
    Esto permitirá que otras clases puedan leer el valor de las propiedades, pero no podrán modificarlas directamente*/
    // public string Palo => palo; / seria lo similar que / public string Palo { get; } Si fuese te tambien escritua añadir set

    private List<Caracteristica> caracteristicas; //Un campo de tipo List<Caracteristica> llamado caracteristicas
    //este campo debe ser accesible solo a la propia clase Naipe: private

    /*
    El constructor de la clase recibe dos parámetros: el nombre y el palo del naipe.
     Estos valores se asignan a los campos correspondientes y se inicializa la lista de características como una lista vacía.
    */
    /*Un constructor publico que reciba como parametros valores para los campos nombre y palo y los asigne a estos campos.*/
    public Naipe(string nombre, string palo) //Un constructor permite inicializar los objetos de esa clase
    {/*Debera respetarse el orden indicado de los parametros*/
        this.nombre = nombre;
        this.palo = palo;
        this.caracteristicas = new List<Caracteristica>();//Además deberá inicializar la lista caracteristicas como una lista vacia
    }

    /*
    La clase también tiene tres métodos públicos: AnadirCaracteristica(), BuscarCaracteristica() y QueCartaGana().
    El primero recibe como parámetro un objeto de la clase Caracteristica y lo añade a la lista caracteristicas del naipe. 
    El segundo recibe como parámetro el nombre de una característica y devuelve el objeto  de la clase Caracteristica con ese nombre.
    El tercer método recibe como parámetros otro objeto de la clase Naipe y el nombre de una característica, y determina cuál de las dos cartas tiene un mejor valor en esa característica usando el método EsMejor() de la clase Caracteristica.
    */
    /*Un metodo publico llamado AnadirCaracteristica(), que recibira como parametro un objeto de la clase Caracteristica*/
    public void AnadirCaracteristica(Caracteristica caracteristica)
    {
        caracteristicas.Add(caracteristica); //Y lo añadira a la lista caracteristicas
    }

    /*Un metodo publico llamado BuscarCaracteristica() que recibirá como parametro un string con el nombre de una caracteristica*/
    public Caracteristica BuscarCaracteristica(string nombreCaracteristica)
    {/*Buscara en la lista caracteristicas*/
        foreach (Caracteristica caracteristica in caracteristicas)
        {
            if (caracteristica.Nombre == nombreCaracteristica) //un objeto Caracteristica con ese nombre
            {
                return caracteristica; //Y lo devolvera
            }
        }
        return null;// Si no se encuentra ninguna caracteristica con ese nombre devolvera null
    }

    /*Un metodo publico llamado QueCartaGana() que recibira como parametros un objeto de tipo Naipe y un string
    con el nombre de una caracteristica*/
    public Naipe QueCartaGana(Naipe otraCarta, string nombreCaracteristica)
    {/*Que se debe usar para comparar la instancia actual con el naipe recibido como parametro.*/
        Caracteristica miCaracteristica = BuscarCaracteristica(nombreCaracteristica);
        Caracteristica otraCaracteristica = otraCarta.BuscarCaracteristica(nombreCaracteristica);

        if (miCaracteristica == null || otraCaracteristica == null)
        {
            return null;
        }
        /*El metodo determinara cual de las 2 cartas tiene un mejor valor en esa caracteristica
        usando el metodo EsMejor() de la clase Caracteristica*/
        if (miCaracteristica.EsMejor(otraCaracteristica))
        {
            return this; //y devolvera el objeto de la clase Naipe al que pertenece la clase ganadora
        }
        else
        {
            return otraCarta;
        }
    }

    /*
    Por último, la clase tiene un método llamado Info() que devuelve una cadena con el palo y el nombre del naipe en el formato especificado.
    */
    /*Un metodo publico llamado Info(), sin parametros, que devolvera el palo del naipe*/
    public virtual string Info() /*El metodo Info debe estar declarado para poder ser sobreescrito
    en las clases que derivende Naipe*/
    {
        return "[" + Palo + "] " + Nombre; //enmarcado entre corchetes, seguido del nombre del naipe.El resultado debera ser:
        //[McDonnell Douglas] MD11
    }
}


