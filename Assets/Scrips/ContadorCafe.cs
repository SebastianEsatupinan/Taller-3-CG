using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorCafe : MonoBehaviour
{
    // Variable estática para llevar un registro de la cantidad de cafés.

    public static int CafeCount = 0;

    void Start()
    {
    }


    // Este método permite aumentar el contador de café.

    private void sumarCafe()
    {
        CafeCount++;
    }

}

//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595