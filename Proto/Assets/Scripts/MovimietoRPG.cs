using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimietoRPG : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    Animator miAnimador;
    Rigidbody2D rb;
    Vector2 movimiento;

    void Start()
    {   
        miAnimador = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");//Cambiar por GetAxisRaw
        movimiento.y = Input.GetAxisRaw("Vertical");//Cambiar por GetAxisRaw
        
        miAnimador.SetFloat("horizontal", movimiento.x);
        miAnimador.SetFloat("vertical", movimiento.y);
        miAnimador.SetFloat("velocidad", movimiento.sqrMagnitude);

        print(movimiento.x);
    }

    void FixedUpdate()
    {
        rb.velocity = movimiento * velocidadMovimiento;
        //rb.MovePosition(rb.position + movimiento * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
