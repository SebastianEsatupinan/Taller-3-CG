using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Ade esta l匤ea para acceder a los componentes de UI

public class ObjectInteract : MonoBehaviour
{
    public Inventario inventario;
    public Text textoCantidad; // Variable para el objeto de texto
    public Text textoTiempo; // Variable para el objeto de texto de tiempo
    private float tiempo = 0.0f;

    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        tiempo = 0.0f;
    }

    void Update()
    {
        // Actualiza el tiempo
        tiempo += Time.deltaTime;
        textoTiempo.text = "Tiempo: " + tiempo.ToString("F2"); // F2 muestra dos decimales
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inventario.Cantidad = inventario.Cantidad + 1;
            Destroy(gameObject);

            // Actualiza el texto con la cantidad acumulada
            textoCantidad.text = "Objetos: " + inventario.Cantidad.ToString();
        }
    }
}
//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595