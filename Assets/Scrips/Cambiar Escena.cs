using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena que deseas cargar
    public string nombreDeEscena;

    // Llamado cuando ocurra alg佖 evento que desee cambiar de escena
    public void CambiarEscena(string v)
    {
        // Cargar la escena por su nombre
        SceneManager.LoadScene(nombreDeEscena);
    }
}

//sebastian Estupiñán Sánchez #2200361
//Juan David Carvajal #2221496
//David Alejandro Perez #2201374
//Miguel Diuza 2215595