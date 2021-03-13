using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject collider = col.collider.gameObject;
        GameObject.Destroy(collider);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Destroy(collider.gameObject);
    }
}
