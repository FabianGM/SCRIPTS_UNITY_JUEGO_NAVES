using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Update()
    {

        // traslade a la dirección que le ponga x,y,z con un velocidad que también establezca
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
