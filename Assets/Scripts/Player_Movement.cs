using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Movement : NetworkBehaviour 
{
    public CharacterController controller;
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;
    private Vector3 velocity;
    private bool isGrounded;
    void Update() 
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0) {
            velocity.y = 0f;
        }
        float moveSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}