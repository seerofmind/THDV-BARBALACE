﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPersonMovement : MonoBehaviour
{
    public PlayerDataSO playerData;

    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        playerData.IsRunning = playerData.canRun && Input.GetKey(playerData.runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = playerData.IsRunning ? playerData.runSpeed : playerData.speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity = new Vector2(Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }

    private void PlayerDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hubo contacto");
        if (collision.gameObject.layer == 7)
        {
            PlayerDeath();
        }
    }
}