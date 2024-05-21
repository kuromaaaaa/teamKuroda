using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterStatusSwitcher : MonoBehaviour
{
    public Sprite shelterOpen;
    public Sprite shelterClose;
    public float switchTime;

    SpriteRenderer shelterRenderer;
    Collider2D shelterCollider;
    // Start is called before the first frame update

    void Start()
    {
        shelterRenderer = GetComponent<SpriteRenderer>();
        shelterCollider = GetComponent<Collider2D>();
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        Debug.Log("a");
        SwitchStatus();
        yield return new WaitForSeconds(switchTime);
        StartCoroutine(Switch());
    }

    public void SwitchStatus()
    {
        if (shelterRenderer.sprite == shelterOpen)
        {
            shelterRenderer.sprite = shelterClose;
            shelterCollider.enabled = false;
        }
        else
        {
            shelterRenderer.sprite = shelterOpen;
            shelterCollider.enabled = true;
        }
    }
}
