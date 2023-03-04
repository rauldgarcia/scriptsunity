using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzar : MonoBehaviour
{
    public GameObject proyectil;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fuerza = new Vector3 (0,0,30);

        float traslaciony = Input.GetAxis("Vertical")*velocidad*Time.deltaTime;
        float traslacionx = Input.GetAxis("Horizontal")*velocidad*Time.deltaTime;
        transform.Translate(traslacionx,traslaciony,0);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject pelota = Instantiate(proyectil, transform.position,
                                                     transform.rotation);
            pelota.GetComponent<Rigidbody>().AddForce(fuerza*velocidad);
            Destroy(pelota.gameObject, 3);
        }
    }
}
