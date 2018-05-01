using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score_Tracker : MonoBehaviour {


    public float startTime;
    public Text TimeUI;
    public float ellapsedTime;
    bool startCounter = true;

    int miliseconds;
    int seconds;

	// Use this for initialization
	void Start ()
    {
	}

    public void StartTimeCounter()
    {
        startTime = Time.time;
        startCounter = true;
    }
    public void StopTimeCounter()
    {
        startCounter = false;
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (startCounter)
        {
            ellapsedTime = Time.time - startTime;
            seconds = (int)ellapsedTime % 60;
            miliseconds = (int)seconds / 60;

            TimeUI.text = string.Format("{00}", seconds);
            ellapsedTime.ToString("dd");
        }
	}
}
