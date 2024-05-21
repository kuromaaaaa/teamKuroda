using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackB : MonoBehaviour
{
    float wait = 0;
    bool triger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(wait);
        if (triger)
        {
            wait += Time.deltaTime;
        }
        if (wait > 3.5)
        {
            SceneManager.LoadScene("Title", LoadSceneMode.Single);
        }
    }
    public void TitleButton()
    {
        triger = true;
    }
}
