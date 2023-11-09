using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionfuerademapa : MonoBehaviour
{

    // Referencia al objeto de punto de reaparición que se utilizará al salir del mapa.

    public GameObject puntoSpawn;


    // Este método se llama automáticamente cuando otro objeto colisiona con el objeto que tiene este script adjunto.

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que colisionó tiene la etiqueta "Player".

        if (other.tag == "Player")
        {
            // Muestra un mensaje de depuración para indicar que el jugador ha salido del mapa.
            Debug.Log("Saliste del mapa");
            // Mueve la posición del jugador al punto de reaparición especificado.
            other.transform.position = puntoSpawn.transform.position;
        }
    }
}

//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595