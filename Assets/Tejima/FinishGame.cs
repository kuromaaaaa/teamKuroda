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
        UnityEditor.EditorApplication.isPlaying = false;//�G�f�B�^�[��̂ݔ���
#else
        Application.Quit();//�r���h���ŃG�f�B�^�[�ȊO�ŋN�����Ă���Ƃ�����
#endif
    }
}
