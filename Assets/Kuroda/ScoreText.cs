using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _text.text = (TimeManager.Instance.Timer.ToString("0.0"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
