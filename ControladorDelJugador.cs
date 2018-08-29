using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladordeljugador : MonoBehaviour
{
    Rigidbody RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoH,0,movimientoV);
        RB.AddForce(movimiento);
    }

}
