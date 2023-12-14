using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{
    public GameObject objetivo;
    public float velocidad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objetivo.transform.position, new Vector3(0,2,0), velocidad * Time.deltaTime);
    }
}
