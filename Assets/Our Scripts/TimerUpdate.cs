using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUpdate : MonoBehaviour
{
    public Text text;
    public GameObject TimerSource;
        // GameManager - hound this object for curr timer

    // Start is called before the first frame update
    void Start()
    {
        TimerSource = GameObject.Find("GameManager"); 
        text.text = "#:##";
    }

    // Update is called once per frame
    void Update()
    { 
        text.text = TimerSource.GetComponent<SoupGameManager>().GetTimer();
    }
}
