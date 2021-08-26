using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWASD02 : MonoBehaviour
{
    public static PlayerMovementWASD02 instance;
    public Rigidbody2D rigidBody;
    public float playerSpeed;
    public Animator myAnim;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigidBody.velocity = new Vector2(-2 * playerSpeed, playerSpeed);
                IdleAnim(-1, 1);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rigidBody.velocity = new Vector2(2 * playerSpeed, playerSpeed);
                IdleAnim(1,1);
            }
            else
            {
                rigidBody.velocity = new Vector2(0, 2 * playerSpeed);
                IdleAnim(0,1);
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.S))
            {
                rigidBody.velocity = new Vector2(-2 * playerSpeed, -playerSpeed);
                IdleAnim(-1,-1);
            }
            else
            {
                rigidBody.velocity = new Vector2(-2 * playerSpeed, 0);
                IdleAnim(-1,0);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.D))
            {
                rigidBody.velocity = new Vector2(2 * playerSpeed, -playerSpeed);
                IdleAnim(1,-1);
            }
            else
            {
                rigidBody.velocity = new Vector2(0, -2 * playerSpeed);
                IdleAnim(0,-1);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(2 * playerSpeed, 0);
            IdleAnim(1,0);
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
        myAnim.SetFloat("MoveX", rigidBody.velocity.x);
        myAnim.SetFloat("MoveY", rigidBody.velocity.y);
    }

    void IdleAnim(float x, float y)
    {
        myAnim.SetFloat("LastMoveX", x);
        myAnim.SetFloat("LastMoveY", y);
    }
}