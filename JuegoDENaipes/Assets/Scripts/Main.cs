using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Se suministra el archivo Main que contiene un script a modo de programa principal.*/
public class Main : MonoBehaviour {
    private List<Naipe> mazo;

    /*El metodo Start()*/
    void Start() {
        //Crea objetos de las clases Naipe y CaracteristicaAvion y los vincula usando el metodo AddCaracteristica()
        //de la clase Naipe
        mazo = new List<Naipe>();

        //Se añade a la lista los elementos
        mazo.Add(CrearNaipe("300", "Airbus", 266, 54, 45, 830, 6670));
        mazo.Add(CrearNaipe("310", "Airbus", 240, 45, 44, 850, 6800));
        mazo.Add(CrearNaipe("320", "Airbus", 150, 38, 35, 828, 6100));
        mazo.Add(CrearNaipe("330", "Airbus", 253, 63, 59, 871, 11750));
        mazo.Add(CrearNaipe("340", "Airbus", 261, 59, 62, 896, 14800));
        mazo.Add(CrearNaipe("380", "Airbus", 555, 68, 80, 928, 15200));

        mazo.Add(CrearNaipe("727", "Boeing", 180, 47, 33, 907, 4450));
        mazo.Add(CrearNaipe("737", "Boeing", 170, 36, 36, 842, 7038));
        mazo.Add(CrearNaipe("747", "Boeing", 452, 71, 60, 893, 9800));
        mazo.Add(CrearNaipe("757", "Boeing", 200, 46, 38, 868, 7222));
        mazo.Add(CrearNaipe("767", "Boeing", 224, 48, 48, 851, 7300));
        mazo.Add(CrearNaipe("777", "Boeing", 440, 64, 61, 905, 9700));

        mazo.Add(CrearNaipe("MD9", "McDonnell Douglas", 90, 32, 27, 903, 2340));
        mazo.Add(CrearNaipe("MD10", "McDonnell Douglas", 250, 55, 47, 982, 6114));
        mazo.Add(CrearNaipe("MD11", "McDonnell Douglas", 323, 62, 52, 876, 12655));
        mazo.Add(CrearNaipe("MD80", "McDonnell Douglas", 130, 40, 32, 811, 4395));
        mazo.Add(CrearNaipe("MD90", "McDonnell Douglas", 153, 44, 31, 931, 3860));
        mazo.Add(CrearNaipe("MD95", "McDonnell Douglas", 106, 37, 28, 808, 3815));

        Listar(mazo);

        Jugar(mazo[0], mazo[1], "Envergadura");
        Jugar(mazo[2], mazo[3], "Pasajeros");
        
    }

    //Se crea el constructor 
    private Naipe CrearNaipe(string nombre, string palo, int pasajeros, int longitud, int envergadura, int crucero, int alcance) {
        Naipe naipe = new Naipe(nombre, palo); 
        naipe.AnadirCaracteristica(new CaracteristicaAvion("Pasajeros", pasajeros));
        naipe.AnadirCaracteristica(new CaracteristicaAvion("Longitud", longitud));
        naipe.AnadirCaracteristica(new CaracteristicaAvion("Envergadura", envergadura));
        naipe.AnadirCaracteristica(new CaracteristicaAvion("Crucero", crucero));
        naipe.AnadirCaracteristica(new CaracteristicaAvion("Alcance", alcance));

        return naipe;
    }

    //El programa lista la informacion disponible usando el metodo Info()
    private void Listar(List<Naipe> mazo) {
        string infoNaipe = "";
        foreach(Naipe naipe in mazo) {
            infoNaipe += naipe.Info() + "\n";          
        }
        Debug.Log(infoNaipe);

    }
    //Realiza 2 envites el 1º entre las 2 primeras cartas del mazo, usando como caracteristica de comparcion la 
    // envergadura, y un 2º usando las 2 cartas siguientes usando como caracteristica el numero de pasajeros
    private void Jugar(Naipe naipeJugador1, Naipe naipeJugador2, string nombreCaracteristica) {
        Caracteristica c1 = naipeJugador1.BuscarCaracteristica(nombreCaracteristica);
        Caracteristica c2 = naipeJugador2.BuscarCaracteristica(nombreCaracteristica);
        if(c1.EsMejor(c2)) {
            ResultadoJugada(naipeJugador1, naipeJugador2, nombreCaracteristica);
        } else {
            ResultadoJugada(naipeJugador2, naipeJugador1, nombreCaracteristica);
        }
    }

    //Las clases creadas siguiendo la especificion funcionaran correctamente con este programa principal y mostraran un listado como este
/*[Airbus] 300
[Airbus] 310
[Airbus] 320
[Airbus] 330
[Airbus] 340
[Airbus] 380
[Boeing] 727
[Boeing] 737
[...]
[Airbus] 310 GANA A [Airbus] 300 en Envergadura
[Airbus] 330 GANA A [Airbus] 320 en Pasajeros*/
    private void ResultadoJugada(Naipe naipeGanador, Naipe naipePerdedor, string nombreCaracteristica) {
        string info = $"{naipeGanador.Info()} GANA A {naipePerdedor.Info()} en {nombreCaracteristica}";
        Debug.Log(info);
    }

}
