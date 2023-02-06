using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager1 : MonoBehaviour
{
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();

    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
