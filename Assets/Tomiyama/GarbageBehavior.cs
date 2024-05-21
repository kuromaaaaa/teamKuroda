using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GarbageBehavior : MonoBehaviour
{
    float r, r2;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        r = Random.Range(-3, -9);
        r2 = Random.Range(5, 9); 
        rb.transform.localScale = new Vector2(r2, r2);
        Destroy(this.gameObject, 10);
    }

    private void Update()
    {
        rb.velocity = new Vector2(r, rb.velocity.y);
    }
}
