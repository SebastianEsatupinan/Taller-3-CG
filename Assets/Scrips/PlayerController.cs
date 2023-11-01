using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 5.0f;
    public float RotationSpeed = 200.0f;
    private Animator Anim;
    public float x, y;
    public float JumpForce = 8.0f;
    private bool isGrounded = true;
    private bool isInteracting = false;

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
            // Aqu� deber�as agregar la l�gica para detectar si el jugador est� cerca de un objeto interactuable y si hace clic en �l.
            // Puedes usar raycasts o colisiones para detectar la interacci�n con el objeto.

            // Si el jugador puede interactuar con el objeto, activa la animaci�n y deshabilita el movimiento.
            Anim.SetBool("Interactua", true);
            isInteracting = true;
            StartCoroutine(DetenerAgarreDespuesDeTiempo(3.5f));
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

}
