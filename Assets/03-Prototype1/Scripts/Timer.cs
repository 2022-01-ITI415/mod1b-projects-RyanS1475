using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerTrack;

    // Start is called before the first frame update
    void Start()
    {
        TimerTrack.text = "Timer: 00:00.000";
    }

    // Update is called once per frame
    void Update()
    {
        float tmpTime = Time.time;
        Debug.Log(tmpTime);
        float minutes = Mathf.Floor(tmpTime / 60);
        int seconds = Mathf.RoundToInt(tmpTime) % 60;
        float millis = tmpTime % 1 * 1000;
        string tmpTimeStr = string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, millis);
        TimerTrack.text = "Timer: " + tmpTimeStr;
    }
}
