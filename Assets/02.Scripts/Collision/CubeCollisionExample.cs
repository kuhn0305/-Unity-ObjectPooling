using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionExample : MonoBehaviour
{
    Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.forward * 10, ForceMode.Impulse);
        }
    }

    private bool isProcessing;

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Target") && isProcessing)
        {
            Debug.Log($"{collision.gameObject.name}");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
