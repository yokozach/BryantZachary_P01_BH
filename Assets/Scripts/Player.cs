using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController playerController;
    public float playerSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (playerController.joystickVec.y != 0)
        {

            rb.velocity = new Vector2(playerController.joystickVec.x * playerSpeed, playerController.joystickVec.y * playerSpeed);
        }
        else
        {
            
            rb.velocity = Vector2.zero;
        }


    }
}
