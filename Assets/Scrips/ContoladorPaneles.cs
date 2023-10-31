using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContoladorPaneles : MonoBehaviour
{
    public GameObject panel; 

    public void MostrarPanel()
    {
        panel.SetActive(true);
    }

    public void OcultarPanel()
    {
        panel.SetActive(false);
    }
}
