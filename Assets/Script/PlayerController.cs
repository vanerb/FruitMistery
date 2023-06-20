using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public float minX = -10f; // Límite mínimo en el eje X
    public float maxX = 10f; // Límite máximo en el eje X

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // Obtiene la entrada horizontal del jugador
        float moveY = rb.velocity.y; // Mantiene la velocidad actual en el eje Y

        // Verificar los límites en el eje X y detener el movimiento si se alcanzan
        if (transform.position.x <= minX && moveX < 0f)
        {
            moveX = 0f;
        }
        else if (transform.position.x >= maxX && moveX > 0f)
        {
            moveX = 0f;
        }

        Vector2 movement = new Vector2(moveX * speed, moveY);
        rb.velocity = movement;
    }
}
