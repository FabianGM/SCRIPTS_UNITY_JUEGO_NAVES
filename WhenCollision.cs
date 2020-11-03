using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenCollision : MonoBehaviour
{
    //Un Trigger  es para identificar cuando dos colisiones se topan
    // de está manera el objeto que entre en la variable collision  
    // será destruido cuando se tope con el collider que tiene este script incrustado

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
