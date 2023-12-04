using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using JetBrains.Annotations;

public class Contador : MonoBehaviour
{
    public TMP_Text contador;
    int monedas;
    public AudioSource SO;
    // Start is called before the first frame update
    void Start()
    {
        SO = GameObject.Find("SO").GetComponent<AudioSource>();
        monedas = 0;
        contador.text = "Monedas = 0";
    }

    public void recolectarMonedas()
    {
            monedas++;
            contador.text = "Monedas = " + monedas;
        if (monedas >= 3)
        {
            Time.timeScale = 0F;
            SO.Stop();
        }
    }

 
}
