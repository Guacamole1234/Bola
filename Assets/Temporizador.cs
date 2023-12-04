using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Temporizador : MonoBehaviour
{
    public TMP_Text temporizador;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        temporizador.text = tiempo.ToString("F2");
    }
}
