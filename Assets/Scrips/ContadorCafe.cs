using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorCafe : MonoBehaviour
{
    public static int CafeCount = 0;

    void Start()
    {
        sumarCafe();
    }

    private void sumarCafe()
    {
        CafeCount++;
    }

}
