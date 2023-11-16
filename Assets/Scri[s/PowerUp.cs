using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed at which the power-up rotates

    private void Update()
    {
        // Rotate the power-up for visual effect
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    // This method is called when the CharacterController touches the power-up
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            // Assuming "Player" is the tag of the GameObject with the XROrigin script

            // Notify the XROrigin script that the player touched the power-up
            XROrigin xrOrigin = hit.gameObject.GetComponentInParent<XROrigin>();
            if (xrOrigin != null)
            {
                // Trigger the power-up effect in the XROrigin script
                xrOrigin.ApplySpeedBoost();

                // Destroy the power-up object
                Destroy(gameObject);
            }
        }
    }
}
