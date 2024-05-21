using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision2D : MonoBehaviour
{
    [SerializeField, Header("当たりはじめ")] UnityEvent enter;
    [SerializeField, Header("当たり中")] UnityEvent stay;
    [SerializeField, Header("離れた時")] UnityEvent exit;
    [SerializeField, Header("Tag")] string tagName;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(collision.gameObject.tag == tagName)
        {
            enter.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagName)
        {
            stay.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagName)
        {
            exit.Invoke();
        }
    }
}
