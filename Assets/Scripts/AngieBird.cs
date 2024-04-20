using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngieBird : MonoBehaviour
{
    private Rigidbody2D _rb;
    private CircleCollider2D _circleCollider;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Start()
    {    
        _rb.isKinematic = true;
        _circleCollider.enabled = false;
    }

    public void LaunchBird(Vector2 direction, float force)
    {
        _rb.isKinematic = false;
        _circleCollider.enabled = true;

        //apply the force
        _rb.AddForce(direction * force, ForceMode2D.Impulse);
    }
}
