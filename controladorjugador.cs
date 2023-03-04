using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorjugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    private Rigidbody rb;
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        float moververtical = Input.GetAxis("Vertical")*velocidad*Time.deltaTime;
        float moverhorizontal = Input.GetAxis("Horizontal")*velocidad*Time.deltaTime;
        Vector3 fuerza = new Vector3 (moverhorizontal,0,moververtical);
        rb.GetComponent<Rigidbody>().AddForce(fuerza*velocidad);   
    }

    void OnTriggerEnter(Collider otro) 
    {
        if (otro.gameObject.tag=="bonus")
        {
            Destroy(otro.gameObject);
        }   
    }
}
