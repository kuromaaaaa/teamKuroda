using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _spead = 3;
    [SerializeField] float _Spead = 1;
    [SerializeField] float _jampPower = 1000;
    bool _isGround = true;
    bool _wJump = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int h = 0;
        {
            if (Input.GetKey(KeyCode.D))
            {
                h += 1;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                h -= 1;
            }
            _rb.AddForce(new Vector2(h * _spead * Time.deltaTime, 0), ForceMode2D.Force);

            if (Input.GetKeyDown(KeyCode.Space) && (_isGround ||_wJump))
            {
                _isGround = false;
                _rb.AddForce(new Vector2(0, _jampPower));
                _wJump = false;
            }
            
            
        }
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("’…’n");
        _isGround = true;
        _wJump = false;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGround =false;
    }
    public void GetItem()
    {
        _wJump = true;
    }
}
