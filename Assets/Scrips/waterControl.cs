﻿using UnityEngine;

public class UnderwaterCamera : MonoBehaviour
{
    public Transform waterObject;
    public Color underwaterColor = Color.blue;
    public float underwaterBlur = 10;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto en el trigger es el agua
        if (other.gameObject == waterObject.gameObject)
        {
            // Cambiamos el color de la c疥ara
            mainCamera.backgroundColor = underwaterColor;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Si el objeto en el trigger es el agua
        if (other.gameObject == waterObject.gameObject)
        {
            // Restauramos el color de la c疥ara
            mainCamera.backgroundColor = Color.white;

        }
    }
}

//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595
