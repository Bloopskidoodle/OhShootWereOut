using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StovetopManager : MonoBehaviour
{
    public bool DebugMode;
    public Button SinkButton;

    private void Awake()
    {
        //Pot emptying mechanic
        SinkButton.onClick.AddListener(EmptyPot);
    }

    // Clear pot contents
    public void EmptyPot()
    {
        PotManager.ClearPot();
        Debug.Log("Pot has been emptied");
    }

    public void SubmitSoup()
    {
        SoupGameManager.SubmitSoup();
    }




    /******************************************************
    ****************** HELPER FUNCTIONS *******************
    ******************************************************/

    //Debug mode Debug.Log
    void DebugModeLog(params string[] s)
    {
        if (DebugMode)
        {
            string logInput = "";
            for (int i=0; i<s.Length; i++)
            {
                logInput += s[i];
            }
            Debug.Log(logInput);
        }
    }

}
