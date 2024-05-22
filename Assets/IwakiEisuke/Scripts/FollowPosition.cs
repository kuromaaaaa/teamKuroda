using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 initPos;
    private void Start()
    {
        initPos = transform.position; 
    }

    void Update()
    {
        transform.position = target.transform.position + initPos;
    }
}
