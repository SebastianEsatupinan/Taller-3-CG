using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Velocidad de rotación del objeto.

    public float speed = 20f;

    // Este método se llama en cada frame del juego.

    // Rotar el objeto alrededor de su eje vertical (up) con la velocidad especificada.
    // La multiplicación por Time.deltaTime hace que la rotación sea suave y dependiente del tiempo.
    void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}


//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595