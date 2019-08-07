using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 8f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, 0);
    }
}
