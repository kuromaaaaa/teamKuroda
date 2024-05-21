using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float min, max;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, min, max), 0, -10);
    }
}
