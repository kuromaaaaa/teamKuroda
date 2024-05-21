using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("制限時間")]
    float timer = 30f;
    public float Timer { get { return timer; } }
    static TimeManager instance;
    static public TimeManager Instance { get { return instance; } }

    [SerializeField] bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            Destroy(instance);
        }
        instance = this;
        //前にあったものを破壊
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            timer -= Time.deltaTime;
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }
}
