using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverpelota : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right*velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        float golpe(Vector2 posicionPelota, Vector2 posicionRaqueta, float alturaRaqueta)
        {
            return(posicionRaqueta.y- posicionPelota.y)/alturaRaqueta;
        }

        if (col.gameObject.name == "raquetaizquierda"){
            float y = golpe (transform.position, col.transform.position, col.collider.bounds.size.y);
            GetComponent<Rigidbody2D>().velocity=new Vector2(1,y)*velocidad;
        }

        if (col.gameObject.name == "raquetaderecha"){
            float y = golpe (transform.position, col.transform.position, col.collider.bounds.size.y);
            GetComponent<Rigidbody2D>().velocity=new Vector2(-1,y)*velocidad;
        }

    }
}
