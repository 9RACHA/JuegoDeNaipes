using System.Collections.Generic;

public class Naipe
{
    /*
    La clase Naipe tiene los campos nombre, palo y caracteristicas. 
    Los dos primeros son de tipo string y se pueden acceder a través de las propiedades Nombre y Palo, respectivamente. El campo caracteristicas es de tipo List<Caracteristica>, es decir, una lista de objetos de tipo Caracteristica.
    */

    private string nombre;
    private string palo;
    private List<Caracteristica> caracteristicas;

    public string Nombre => nombre;
    public string Palo => palo;

    /*
    El constructor de la clase recibe dos parámetros: el nombre y el palo del naipe.
     Estos valores se asignan a los campos correspondientes y se inicializa la lista de características como una lista vacía.
    */
    public Naipe(string nombre, string palo)
    {
        this.nombre = nombre;
        this.palo = palo;
        this.caracteristicas = new List<Caracteristica>();
    }

    /*
    La clase también tiene tres métodos públicos: AnadirCaracteristica(), BuscarCaracteristica() y QueCartaGana().
    El primero recibe como parámetro un objeto de la clase Caracteristica y lo añade a la lista caracteristicas del naipe. 
    El segundo recibe como parámetro el nombre de una característica y devuelve el objeto  de la clase Caracteristica con ese nombre.
    El tercer método recibe como parámetros otro objeto de la clase Naipe y el nombre de una característica, y determina cuál de las dos cartas tiene un mejor valor en esa característica usando el método EsMejor() de la clase Caracteristica.
    */
    public void AnadirCaracteristica(Caracteristica caracteristica)
    {
        caracteristicas.Add(caracteristica);
    }

    public Caracteristica BuscarCaracteristica(string nombreCaracteristica)
    {
        foreach (Caracteristica caracteristica in caracteristicas)
        {
            if (caracteristica.Nombre == nombreCaracteristica)
            {
                return caracteristica;
            }
        }
        return null;
    }

    public Naipe QueCartaGana(Naipe otraCarta, string nombreCaracteristica)
    {
        Caracteristica miCaracteristica = BuscarCaracteristica(nombreCaracteristica);
        Caracteristica otraCaracteristica = otraCarta.BuscarCaracteristica(nombreCaracteristica);

        if (miCaracteristica == null || otraCaracteristica == null)
        {
            return null;
        }

        if (miCaracteristica.EsMejor(otraCaracteristica))
        {
            return this;
        }
        else
        {
            return otraCarta;
        }
    }

    /*
    Por último, la clase tiene un método llamado Info() que devuelve una cadena con el palo y el nombre del naipe en el formato especificado.
    */
    public string Info()
    {
        return "[" + Palo + "] " + Nombre;
    }
}


