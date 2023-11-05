using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 5.0f;
    public float RotationSpeed = 200.0f;
    private Animator Anim;
    public float x, y;
    public float JumpForce = 8.0f;
    private bool isGrounded = true;
    private bool isInteracting = false;
    public TextMeshProUGUI cafeCountText;
    public CambioDeEscena cambioDeEscena;
    private Rigidbody rgbd;

    void Start()
    {
        Anim = GetComponent<Animator>();
        rgbd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!isInteracting) // Solo permite mover al jugador si no est� interactuando
        {
            transform.Rotate(0, x * Time.deltaTime * RotationSpeed, 0);
            transform.Translate(0, 0, y * Time.deltaTime * MovementSpeed);
        }
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Anim.SetFloat("VelX", x);
        Anim.SetFloat("VelY", y);

        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        if (isGrounded)
        {
            Anim.SetBool("Jumping", false);
            //Anim.SetBool("Fall", false);

            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }
        //else
        //{
        //    Anim.SetBool("Fall", true);
        //}
        if (Input.GetMouseButtonDown(0))
        {
            Agarrar();  
        }

    }

    public void Jump()
    {
        Anim.SetBool("Jumping", true);
        rgbd.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }

    public void Agarrar()
    {
        if (!isInteracting)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
            {
                if (hit.collider.tag == "Cafe")
                {
                    // Eliminar el objeto
                    Destroy(hit.collider.gameObject);

                    // Sumar al contador
                    ContadorCafe.CafeCount++;
                    cafeCountText.text = "" + ContadorCafe.CafeCount;
                    if (ContadorCafe.CafeCount >= 10)
                    {
                        CambiarEscena("Nivel2");
                    }

                    // Aqu� va el c�digo para interactuar con el objeto
                    Anim.SetBool("Interactua", true);
                    isInteracting = true;
                    StartCoroutine(DetenerAgarreDespuesDeTiempo(3.5f));
                    Debug.Log("Objetos Cafe alzados: " + ContadorCafe.CafeCount);
                }
            }
        }
    }

    IEnumerator DetenerAgarreDespuesDeTiempo(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);

        // Det�n la animaci�n de agarre y habilita el movimiento.
        TerminarAgarre();
    }
    // Agrega un m�todo para finalizar la animaci�n de agarrar y habilitar el movimiento nuevamente.
    public void TerminarAgarre()
    {
        Anim.SetBool("Interactua", false);
        isInteracting = false;
    }
    public void CambiarEscena(string nombreDeEscena)
    {
        SceneManager.LoadScene(nombreDeEscena);
    }

}
