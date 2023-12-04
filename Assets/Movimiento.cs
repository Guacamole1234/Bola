using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody Cuerpo;
    public float Velocidad;
    bool Saltando = false;
    public float FuerzaSalto = 5f;
    public Contador contador;
    // Start is called before the first frame update
    void Start()
    {
        Cuerpo = GetComponent<Rigidbody>();
        Velocidad = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        Cuerpo.velocity = new Vector3(movHorizontal * Velocidad, Cuerpo.velocity.y ,movVertical * Velocidad);
        Saltando = Input.GetButtonDown("Jump");

        if (Saltando)
        {
            Cuerpo.AddForce(new Vector3(0, FuerzaSalto, 0), ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monedas")
        {
            contador.recolectarMonedas();
        }
    }
}
