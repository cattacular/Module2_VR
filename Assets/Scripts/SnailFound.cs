using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailFound : MonoBehaviour
{
    private Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {   
        if(spawn != transform.position)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            enabled = false;
        }
    }
}
