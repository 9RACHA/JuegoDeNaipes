# JuegoDeNaipes

Realizar un proyecto en Unity llamado JuegoDeNaipes con las siguientes especificaciones.

El objetivo del proyecto es crear un sistema que permita crear barajas de cartas del tipo de las que
representan objetos del mundo real, como coches, futbolistas, países, etc. y realizar las operaciones
de comparación entre ellas que permiten llevar a cabo juegos en los que un jugador lanza un envite
apostando con una de las características una carta que le pertenece contra la misma característica de
la carta del oponente, quedándose con ambas cartas quien tenga el mejor valor en dicha
característica.

A modo de demo se creará un mazo de cartas de aviones de pasajeros, y se listará en la consola de
Unity. Además se tomarán las dos primeras parejas de cartas del mazo y se mostrará el resultado de
un envite para cada pareja, basado cada uno en una característica diferente de entre las disponibles.
Para ello necesitamos crear las clases Naipe, Propiedad y PropiedadAvion, que deben ser
programadas por el alumno conforme a las siguientes especificaciones.

## Clase Naipe
La clase Naipe debe ser una clase que contendrá el comportamiento de los naipes de cualquier
baraja. Poseerá los campos y métodos necesarios para manejar el comportamiento y la
funcionalidad común a todos los naipes. Debe incluir lo siguiente:

Un campo de tipo string llamado nombre.

Una propiedad de tipo string llamada Nombre que devolverá el valor del campo nombre.

Un campo privado de tipo string llamado palo.

Una propiedad de tipo string llamada Palo que devolverá el valor del campo palo.

Los dos campos deben ser accesibles sólo a la propia clase Naipe.

Las dos propiedades deben ser públicamente accesibles y de sólo lectura.

Un campo de tipo List<Caracteristica> llamado caracteristicas. Este campo debe ser
accesible sólo a la propia clase Naipe.

Un constructor público que reciba como parámetros valores para los campos nombre y palo y los
asigne a estos campos. Además deberá inicializar la lista caracteristicas como una lista vacía.
Debe respetarse el orden indicado de los parámetros.

Un método público llamado AnadirCaracteristica(), que recibirá como parámetro un objeto de
la clase Caracteristica y lo añadirá a la lista caracteristicas.

Un método público llamado BuscarCaracteristica() que recibirá como parámetro un string
con el nombre de una característica, buscará en la lista caracteristicas un objeto
Caracteristica con ese nombre y lo devolverá. Si no se encuentra ninguna característica con ese
nombre, devolverá null.

Un método público llamado QueCartaGana() que recibirá como parámetros un objeto de tipo
Naipe y un string con el nombre de una característica que se debe usar para comparar la instancia
actual con el naipe recibido como parámetro. El método determinará cual de las dos cartas tiene un
mejor valor en esa característica usando el método EsMejor() de la clase Caracteristica y
devolverá el objeto de la clase Naipe al que pertenece la característica ganadora.

Un método público llamado Info(), sin parámetros, que devolverá el palo del naipe, enmarcado
entre corchetes, seguido del nombre del naipe. El resultado deberá ser como el del ejemplo:

[McDonnell Douglas] MD11

El método Info() debe estar declarado para poder ser sobreescrito en las clases que deriven de
Naipe, aunque en este proyecto no se crea ninguna clase de esta manera.

## Clase Caracteristica
La clase Caracteristica debe ser una clase abstracta que servirá para representar las
características de los objetos representados en los naipes y que serán los que determinen la jugada
ganadora. Establecerá los campos y métodos necesarios para manejar la comparación entre las
características de dos naipes enfrentados, dejando los detalles de implementación para cada
característica en particular a las clases derivadas.

Debe incluir lo siguiente:

Un campo de tipo string llamado nombre.

Una propiedad de tipo string llamada Nombre que devolverá el valor del campo nombre.

Un campo de tipo int llamado valor.

Una propiedad de tipo int llamada Valor que devolverá el valor del campo nombre.

Los dos campos deben ser accesibles sólo a la propia clase Caracteristica y a las que de ella
deriven.

Las dos propiedades deben ser públicamente accesibles y de sólo lectura.

Un constructor público que reciba como parámetros valores para los campos nombre y valor y los
asigne a estos campos.

Un método abstracto EsMejor() que recibirá como parámetro un objeto de la clase
Caracteristica y devolverá un bool.

## Clase CaracteristicaAvion
La clase CaracteristicaAvion descenderá de Caracteristica.

El constructor del la clase CaracteristicaAvion recibirá como parámetros valores para los
campos nombre y valor. Invocará al constructor de la clase base pasándole esos valores.

La implementación del método EsMejor() comprobará si el nombre de la característica es
“Envergadura”. En ese caso devolverá el resultado de comparar si el valor del propio objeto
Caracteristica es menor que el del objeto Caracteristica recibido como parámetro.

En caso de que el nombre sea otro, se devolverá el resultado de comparar si el valor del propio
objeto Caracteristica es mayor que el del objeto Caracteristica recibido como parámetro.

Se supondrá que tanto el propio objeto como el objeto recibido como parámetro tienen el mismo
nombre, por lo que la comprobación de éste se podrá hacer indistintamente en cualquiera de los dos.

## Programa principal
Se suministra el archivo Main.cs que contiene un script a modo de programa principal. El método
Start() de este script crea objetos de las clases Naipe, y CaracteristicaAvion y los vincula
usando el método AddCaracteristica() de la clase Naipe.

El programa después lista la información disponible usando el método Info() y realiza dos envites,
el primero entre las dos primeras cartas del mazo, usando como característica de comparación la
envergadura, y un segundo usado las dos cartas siguientes usando como característica el número de
pasajeros.

Las clases creadas siguiendo la especificación funcionarán correctamente con este programa
principal y mostrarán un listado como este:

[Airbus] 300
[Airbus] 310
[Airbus] 320
[Airbus] 330
[Airbus] 340
[Airbus] 380
[Boeing] 727
[Boeing] 737
[...]
[Airbus] 310 GANA A [Airbus] 300 en Envergadura
[Airbus] 330 GANA A [Airbus] 320 en Pasajeros
