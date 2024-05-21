using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HP : MonoBehaviour
{
    public static float hp { get; set; }

    [SerializeField] float maxHP;
    [SerializeField] UnityEvent gameoverEvent;

    void Start()
    {
        hp = maxHP;
    }

    void Update()
    {
        hp = Mathf.Clamp(hp, 0, maxHP);

        Debug.Log(hp);

        if (hp <= 0)
        {
            gameoverEvent.Invoke();
        }
    }
}
