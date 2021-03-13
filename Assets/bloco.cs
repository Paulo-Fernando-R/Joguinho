using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        rigidbody.constraints = new RigidbodyConstraints2D();
    }
}
