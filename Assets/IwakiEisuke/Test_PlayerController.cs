using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float speed;
    public bool canJump;
    public SpriteRenderer debug_renderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Shelter"))
        {
            debug_renderer.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Shelter"))
        {
            debug_renderer.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
    }
}
