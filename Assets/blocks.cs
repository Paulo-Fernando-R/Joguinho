using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    //public Collider2D collider;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        //collider.GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.constraints = new RigidbodyConstraints2D();
        GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
