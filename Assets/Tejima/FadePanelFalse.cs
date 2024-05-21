using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanelFalse : MonoBehaviour
{
    float none = 0;
    [SerializeField] GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        none += Time.deltaTime;
        if (none > 3.5) 
        {
            GameObject.SetActive(false);
        }
    }
}
