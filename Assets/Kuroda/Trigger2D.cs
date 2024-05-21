using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Trigger2D : MonoBehaviour
{
    [SerializeField, Header("当たりはじめ")] UnityEvent enter;
    [SerializeField, Header("当たり中")] UnityEvent stay;
    [SerializeField, Header("離れた時")] UnityEvent exit;
    [SerializeField, Header("Tag")] string tagName;

    private void Start()
    {
        Debug.Log(tagName == string.Empty);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tagName != string.Empty && collision.gameObject.tag == tagName)
        {
            enter.Invoke();
        }
        else if(tagName == string.Empty)
        {
            enter.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (tagName != string.Empty && collision.gameObject.tag == tagName)
        {
            stay.Invoke();
        }
        else if (tagName == string.Empty)
        {
            stay.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (tagName != string.Empty && collision.gameObject.tag == tagName)
        {
            exit.Invoke();
        }
        else if (tagName == string.Empty)
        {
            exit.Invoke();
        }
    }
}
