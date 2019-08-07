using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour
{
    public Vector2 direction;
    public float velocity;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball"))
        {
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            rb.velocity = direction.normalized * velocity;
        }
    }
}
