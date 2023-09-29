using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform Autito;
    public float DistanciaCamara;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Autito != null)
        {
            Vector3 posicioncamara = Autito.position - Autito.forward * DistanciaCamara;
            transform.LookAt(posicioncamara, Vector3.up);
        }
    }
}
