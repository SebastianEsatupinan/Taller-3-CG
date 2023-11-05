using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorCafe : MonoBehaviour
{
    public static int CafeCount = 0;

    void Start()
    {
    }

    private void sumarCafe()
    {
        CafeCount++;
    }

}
