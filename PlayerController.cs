using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform shootOrigin;
    public GameObject shootPrefab;
    public float xMin, xMax;

    void Update()
    {

        //movimiento w,d dinámico para que valga con varios botones
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            transform.position.z, transform.position.z);
        //Establezco un rango para limitar por donde se mueva el pj
        float x = Mathf.Clamp(transform.position.x, xMin, xMax);
        transform.position = new Vector3(x,0,0);
        //Poner un botón para el Shoot tanto para pc, android, etc
        if (Input.GetButtonDown("Shoot")){
            // Se crea la bala cada vez que aplasto espacio con todo y script mover
            Instantiate(shootPrefab, shootOrigin, false);
        }

    }
}
