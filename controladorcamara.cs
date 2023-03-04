using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorcamara : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject jugador;
    private Vector3 compensacion;
    void Start()
    {
        compensacion= transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=jugador.transform.position+compensacion;
    }
}
