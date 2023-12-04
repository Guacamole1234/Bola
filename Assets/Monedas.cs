using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public AudioSource FX;
    // Start is called before the first frame update
    void Start()
    {
        FX = GameObject.Find("FX").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            FX.Play();
            Destroy(gameObject);
        }
    }
}
