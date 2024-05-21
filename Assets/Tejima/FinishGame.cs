using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Finish()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//エディター上のみ反応
#else
        Application.Quit();//ビルド等でエディター以外で起動しているとき反応
#endif
    }
}
