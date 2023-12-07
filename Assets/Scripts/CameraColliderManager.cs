using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Find the MainCamera in the scene
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // Add Box Collider to MainCamera
            BoxCollider boxCollider = mainCamera.gameObject.AddComponent<BoxCollider>();
            boxCollider.isTrigger = true; // Set collider as trigger to detect collisions without physics interactions
            Debug.Log("MainCamera is found and boxcollider added");

            Rigidbody rigidbody = mainCamera.GetComponent<Rigidbody>();
            if (rigidbody == null)
            {
                // Add Rigidbody if not already present
                rigidbody = mainCamera.gameObject.AddComponent<Rigidbody>();
            }
            rigidbody.useGravity = false;
            rigidbody.isKinematic = true;

        }
        else
        {
            Debug.LogError("MainCamera not found in the scene!");
        }
    }

}
