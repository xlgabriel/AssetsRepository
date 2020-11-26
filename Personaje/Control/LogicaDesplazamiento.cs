using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class LogicaDesplazamiento : MonoBehaviour
{
    public float velocidadM;
    public float velocidadR;
    private Animator animacion;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        velocidadM = 5f;
        velocidadR = 200f;
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadM);

        animacion.SetFloat("VelocidadX",x);
        animacion.SetFloat("VelocidadY", y);
    }
}
