using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterStatusSwitcher : MonoBehaviour
{
    [SerializeField] Sprite shelterOpen;
    [SerializeField] Sprite shelterClose;
    [SerializeField] float[] switchTime;
    [SerializeField] bool initOpen;

    SpriteRenderer shelterRenderer;
    Collider2D shelterTrigger, shelterCollision;
    int switchIndex;

    void Start()
    {
        shelterRenderer = GetComponent<SpriteRenderer>();
        shelterTrigger = GetComponent<BoxCollider2D>();
        shelterCollision = GetComponent<PolygonCollider2D>();
        if (initOpen)
        {
            TurnOpen();
        }
        else
        {
            TurnOff();
        }
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(switchTime[switchIndex]);
        SwitchStatus();
        StartCoroutine(Switch());
    }

    public void SwitchStatus()
    {
        if (shelterRenderer.sprite == shelterOpen)
        {
            TurnOff();
        }
        else
        {
            TurnOpen();
        }
        switchIndex = (switchIndex + 1) % switchTime.Length;
    }

    void TurnOpen()
    {
        shelterRenderer.sprite = shelterOpen;
        shelterTrigger.enabled = true;
        shelterCollision.enabled = true;
    }

    void TurnOff()
    {
        shelterRenderer.sprite = shelterClose;
        shelterTrigger.enabled = false;
        shelterCollision.enabled = false;
    }
}
