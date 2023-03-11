using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverraqueta1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public string eje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float y=Input.GetAxis(eje);
        GetComponent<Rigidbody2D>().velocity=new Vector2 (0,y)*velocidad;
    }
}
