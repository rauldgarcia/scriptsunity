using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverseleccion : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject objeto;
    void Start()
    {
        objeto=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(objeto != null){
            float valory=Input.GetAxis("Vertical");
            float valorx=Input.GetAxis("Horizontal");
            objeto.transform.Translate(valorx*Time.deltaTime,valory*Time.deltaTime,0);
        }
    }
}
