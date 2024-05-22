using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterStatusSwitcher : MonoBehaviour
{
    [SerializeField] Sprite shelterOpen;
    [SerializeField] Sprite shelterClose;
    [SerializeField] float[] switchTime;

    SpriteRenderer shelterRenderer;
    Collider2D shelterTrigger, shelterCollision;
    int switchIndex;

    void Start()
    {
        shelterRenderer = GetComponent<SpriteRenderer>();
        shelterTrigger = GetComponent<BoxCollider2D>();
        shelterCollision = GetComponent<PolygonCollider2D>();
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        SwitchStatus();
        yield return new WaitForSeconds(switchTime[switchIndex]);
        switchIndex = (switchIndex + 1) % switchTime.Length;
        StartCoroutine(Switch());
    }

    public void SwitchStatus()
    {
        if (shelterRenderer.sprite == shelterOpen)
        {
            shelterRenderer.sprite = shelterClose;
            shelterTrigger.enabled = false;
            shelterCollision.enabled = false;
        }
        else
        {
            shelterRenderer.sprite = shelterOpen;
            shelterTrigger.enabled = true;
            shelterCollision.enabled = true;
        }
    }
}
