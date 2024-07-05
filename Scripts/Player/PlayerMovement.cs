using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 10f;

    public float gravity = -9.81f;

    public Transform groundCheck;

    public float sphereRadius = 0.3f;
    public LayerMask groundMask;

    bool isGrounded;
    Vector3 velocity;
     
    public float jumpHeight = 3f;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        animator.SetFloat("Velx", x);
        animator.SetFloat("Velz", z);

        Vector3 move = transform.right * x + transform.forward * z;

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);

    }
}
