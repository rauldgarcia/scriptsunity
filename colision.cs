using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update
    public Material colorM;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
        this.rend.sharedMaterial = colorM;   
    }
}
