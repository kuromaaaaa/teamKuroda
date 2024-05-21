using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _spead = 3;
    bool _isGround = true;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = new Vector2(1 * _spead, _rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector2(-1 * _spead, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space) && _isGround)
        {
            _isGround = false;
            _rb.AddForce(new Vector2(0, 500));
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGround=true;
    }
}
