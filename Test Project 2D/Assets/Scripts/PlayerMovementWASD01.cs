using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWASD01 : MonoBehaviour
{
    public static PlayerMovementWASD01 instance;
    public Rigidbody2D rigidBody;
    public float playerSpeed;
    public Animator myAnim;
    public bool canMove = true;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (canMove)
        {
            Vector2 currentPos = rigidBody.position;
            Vector2 inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            inputVector = Vector2.ClampMagnitude(inputVector, 1);
            Vector2 movement = inputVector * playerSpeed;
            Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
            rigidBody.MovePosition(newPos);
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
    }
}