﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Init();
    }

    void Init()
    {
        rb.velocity = new Vector2(velocity, velocity);
    }
}
