using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("制限時間")]
    float _timer = 30f;
    public float Timer { get { return _timer; } }
    static TimeManager _instance;
    static public TimeManager Instance { get { return _instance; } }

    [SerializeField] bool _timerStop = false;
    [SerializeField] UnityEvent _gameOver;
    // Start is called before the first frame update
    void Start()
    {
        if(_instance != null)
        {
            Destroy(_instance.gameObject);
        }
        _instance = this;
        //前にあったものを破壊
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!_timerStop)
        {
            _timer -= Time.deltaTime;
        }
        if(!_timerStop && _timer < 0)
        {
            //タイムオーバー
            TimerStop();
            _timer = 0;
            _gameOver.Invoke();
        }
    }

    public void TimerStop()
    {
        _timerStop = true;
    }
}
