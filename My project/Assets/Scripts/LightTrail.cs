using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrail : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Vehicle;
    private Vector3 offset = new Vector3(-0.16f, 1.14f, 3.93f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vehicle.transform.position + offset;
    }
}
