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
        instance = this;
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

            myAnim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

            if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
                myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
    }
}