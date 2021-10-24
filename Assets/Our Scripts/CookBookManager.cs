using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookBookManager : MonoBehaviour
{
    public bool DebugMode;

    public GameObject[] pages;
    private int currPageIndex = 0;

    // Start calls before first frame
    void Start()
    {
        for ( int i=0; i<pages.Length; i++ )
        {
            pages[i].GetComponent<Renderer>().enabled = false;
        }
        currPageIndex = 0;
        pages[currPageIndex].GetComponent<Renderer>().enabled = true;
        DebugModeLog("DebugMode is active...");
    }

    // Forward page button press
    // TODO: Check not beyond array boundaries
    public void PageForward()
    {
        DebugModeLog("PageForward()");
        pages[currPageIndex].GetComponent<Renderer>().enabled = false;
        currPageIndex++;
        if (WithinArrayRange())
        {
            pages[currPageIndex].GetComponent<Renderer>().enabled = true;
        }else{
            currPageIndex--;
            pages[currPageIndex].GetComponent<Renderer>().enabled = true;
        }
        
    }

    // Back page button press
    // TODO: Check not beyond array boundaries
    public void PageBack()
    {
        DebugModeLog("PageBack()");
        pages[currPageIndex].GetComponent<Renderer>().enabled = false;
        currPageIndex--;
        if (WithinArrayRange())
        {
            pages[currPageIndex].GetComponent<Renderer>().enabled = true;
        }else{
            currPageIndex++;
            pages[currPageIndex].GetComponent<Renderer>().enabled = true;
        }
    }


    /******************************************************
    ****************** HELPER FUNCTIONS *******************
    ******************************************************/

    // Assertion conditional element. Check you do not flip to
    //  pages beyond the size of the array, or to page -1.
    bool WithinArrayRange()
    {
        if ( (currPageIndex >= 0) && (currPageIndex < pages.Length) )
        {
            return true;
        }else{
            Debug.Log("No more pages beyond this!");
            return false;
        }
    }

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
