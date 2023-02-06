using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    PlayerManager1 playerManager;
    InputManager inputManager;

    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody playerRigidBody;

    public float movementSpeed = 7;
    public float rotationSpeed = 15;
    //Vector3 customV3 = new Vector3(5.0f, 0.0f, 0.0f);
    //Vector3 customV32 = new Vector3(5.0f, 0.0f, 0.0f);

    /*[Header("Movement Flags")]
    public bool isJumping;*/

    /*[Header("Jump Speeds")]
    public float jumpingHeight = 3;
    public float gravityIntensity = -15;*/

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidBody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        HandleMovement();
        HandleRotation();
        //HandleJumping();
        Physics.gravity = new Vector3(0, -1000F, 0);
    }

    private void HandleMovement()
    {
        moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * 60;

        Vector3 movementVelocity = moveDirection;
        playerRigidBody.velocity = movementVelocity;
    }

    private void HandleRotation()
    {
        Vector3 targetDirection = Vector3.zero;
        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }

    /*public void HandleJumping()
    {
        isJumping = inputManager.jumpInput;
        if (isJumping)
        {
            float jumpingVelocity = Mathf.Sqrt(-2f * gravityIntensity * jumpingHeight);
            Vector3 playerVelocity = moveDirection;
            playerVelocity.y = jumpingVelocity;
            playerRigidBody.velocity = playerVelocity;
        }
            float jumpingVelocity2 = gravityIntensity * Time.deltaTime;
            Vector3 playerVelocity2 = moveDirection;
            playerVelocity2.y = jumpingVelocity2;
            playerRigidBody.velocity = playerVelocity2;

    }*/
}
