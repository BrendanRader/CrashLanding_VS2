using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;
    private Animator animator;

    [SerializeField]
    private float moveSpeed = 10;

    [SerializeField]
    private float turnSpeed = 100f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);

        animator.SetFloat("Speed", vertical);

        characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);

        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);

        
        if (movement.magnitude > 0)
        {
            Quaternion newDirection = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, newDirection, Time.deltaTime * turnSpeed);
        }
       

        if (vertical !=0)
        {
            characterController.SimpleMove(transform.forward * moveSpeed * vertical);
        }
    }
}
