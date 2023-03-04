using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inicio");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Nombre"+nombre);
    }
}
