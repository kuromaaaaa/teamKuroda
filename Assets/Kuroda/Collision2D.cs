using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision2D : MonoBehaviour
{
    [SerializeField, Header("当たりはじめ")] UnityEvent _enter;
    [SerializeField, Header("当たり中")] UnityEvent _stay;
    [SerializeField, Header("離れた時")] UnityEvent _exit;
    [SerializeField, Header("Tag")] string _tagName;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (_tagName != string.Empty && collision.gameObject.tag == _tagName)
        {
            _enter.Invoke();
        }
        else if (_tagName == string.Empty)
        {
            _enter.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_tagName != string.Empty && collision.gameObject.tag == _tagName)
        {
            _stay.Invoke();
        }
        else if (_tagName == string.Empty)
        {
            _stay.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_tagName != string.Empty && collision.gameObject.tag == _tagName)
        {
            _exit.Invoke();
        }
        else if (_tagName == string.Empty)
        {
            _exit.Invoke();
        }
    }
}
