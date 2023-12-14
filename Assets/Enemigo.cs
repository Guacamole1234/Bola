using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objetivo);
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Time.timeScale = 0f;
        }
    }
}
