using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpForce, speed;
    [SerializeField] bool canJump, inShelter;
    [SerializeField] SpriteRenderer debug_renderer;

    bool _wJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && (canJump || _wJump))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
            _wJump = false;
        }

        //inShelter Ç™ true => âÒïú : false => å∏è≠
        HP.hp += inShelter ? Time.deltaTime : -Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shelter"))
        {
            inShelter = true;
            debug_renderer.enabled = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Shelter"))
        {
            inShelter = false;
            debug_renderer.enabled = false;
        }
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            _wJump = false;
        }
    }

    private void OnCollisionExit2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
    }

    public void GetItem()
    {
        _wJump = true;
    }
}
