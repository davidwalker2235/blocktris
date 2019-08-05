using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 pos;
    public float speed = 0.8f;
    public float leftBound = -2.5f;
    public float paddleSpeed = 0.8f;
    private float yPosition = -1.58f;
    private Vector3 playerPos = new Vector3(0, -1.58f, 0);

    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -speed, speed), yPosition, 0f);
        transform.position = playerPos;

    }
}
