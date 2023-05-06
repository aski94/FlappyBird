using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    public float jumpForce = 10;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //Starting Jump 
        rb2d.velocity = Vector2.up * jumpForce;
    }

    void Update()
    { 
        if (Input.GetKeyDown("space"))
        {
            // Debug.Log("space");
            
            rb2d.velocity = Vector2.up * jumpForce;
           
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 7)
        {
            // Debug.Log("Score");
            ScoreCount.score++;
        }
    }
}
