using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotata : MonoBehaviour
{

    public float rotationSpeed = 90f; // degrees per second

    void Update()
    {
      
        
            Debug.Log("Rotating reticle: " + gameObject.name);
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        
    }
}