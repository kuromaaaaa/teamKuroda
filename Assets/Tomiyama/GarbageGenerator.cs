using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageGenerator : MonoBehaviour
{
    float time;
    [SerializeField]float interval = 3;
    [SerializeField] GameObject garbagePrefab;

    void Update()
    {
        GameObject gb;
        time += Time.deltaTime;
        if (time > interval)
        {
            gb = Instantiate(garbagePrefab);
            gb.transform.position = this.transform.position;
            time = 0;
        }
    }
}
