using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 pos;
    public float speed = 0.5f;
    public float rigthBound = 2.5f;
    public float leftBound = -2.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = rb.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the paddle
        pos.x = Input.GetAxis("Horizontal") * speed;
        transform.position = pos;

        // add boundaries to paddle
        if(transform.position.x > rigthBound)
        {
            transform.position = new Vector3(rigthBound, transform.position.y, 0);
        } else if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, 0);
        }
    }
}
