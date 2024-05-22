using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSet: MonoBehaviour
{
    Animator _anim;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _anim.SetFloat("velX", Mathf.Abs(_rb.velocity.x));
        _anim.SetFloat("velY", _rb.velocity.y);
    }
}
