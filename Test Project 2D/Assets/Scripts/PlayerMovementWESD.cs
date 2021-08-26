using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWESD : MonoBehaviour
{
    public static PlayerMovementWESD instance;
    public Rigidbody2D rigidBody;
    public float playerSpeed;
    public Animator myAnim;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rigidBody.velocity = new Vector2(2 * playerSpeed, playerSpeed);
            myAnim.SetFloat("LastMoveX", 1);
            myAnim.SetFloat("LastMoveY", 1);
        }   
        else if(Input.GetKey(KeyCode.W))
        {
            rigidBody.velocity = new Vector2(-2 * playerSpeed, playerSpeed);
            myAnim.SetFloat("LastMoveX", -1);
            myAnim.SetFloat("LastMoveY", 1); 
        }
        else if(Input.GetKey(KeyCode.S))
        {
            rigidBody.velocity = new Vector2(-2 * playerSpeed, -playerSpeed);
            myAnim.SetFloat("LastMoveX", -1);
            myAnim.SetFloat("LastMoveY", -1);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(2 * playerSpeed, -playerSpeed);
            myAnim.SetFloat("LastMoveX", 1);
            myAnim.SetFloat("LastMoveY", -1);
            
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
        myAnim.SetFloat("MoveX", rigidBody.velocity.x);
        myAnim.SetFloat("MoveY", rigidBody.velocity.y);
    }
}