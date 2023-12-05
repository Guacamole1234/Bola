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


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            FX.Play();
          
            ParticleSystem particulas =
             gameObject.GetComponent<ParticleSystem>();
            particulas.Play();
            Invoke("destruirObjeto", particulas.duration);
           
        }
        
    }

    void destruirObjeto()
    {
            Destroy(gameObject);
    }


}
