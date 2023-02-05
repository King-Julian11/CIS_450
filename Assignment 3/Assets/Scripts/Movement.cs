/* Julian Salgado
 * Movement.cs
 * Assignment 3
 * Manages movement of sphere/subject game object.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    private bool grounded;
    private float speed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravity = -9.81f;

    // Start is called before the first frame update
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = controller.isGrounded;
        if (grounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
