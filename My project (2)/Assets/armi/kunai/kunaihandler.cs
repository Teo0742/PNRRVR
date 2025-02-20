using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunaispawner1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * 5, ForceMode.VelocityChange);
        Destroy(gameObject, 5f);   
    }
}
