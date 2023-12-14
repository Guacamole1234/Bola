using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cámara : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 1;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objetivo.position, velocidad * Time.deltaTime);
    }
}
