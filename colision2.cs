using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision2 : MonoBehaviour
{
    public Material [] materials;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Objeto entrando");
        rend.sharedMaterial=materials[0];        
    }

    void OnTriggerStay (Collider other)
    {
        Debug.Log("Objeto adentro");
        rend.sharedMaterial=materials[1];        
    }

    void OnTriggerExit (Collider other)
    {
        Debug.Log("Objeto saliendo");
        rend.sharedMaterial=materials[2];        
    }
}
