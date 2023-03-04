using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientofuerza : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(1,0,0);
    }
}
