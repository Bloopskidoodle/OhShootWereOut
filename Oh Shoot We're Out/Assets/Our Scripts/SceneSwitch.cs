using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    //Return to Zoomed-Out scene
    public void SceneSwitchZoomOut() 
    {
        SceneManager.LoadScene(0);
    }

    //Go to Cooking Pot Station
    public void SceneSwitchPot()
    {
        SceneManager.LoadScene(1);
    }
    
    //Go to Cookbook
    public void SceneSwitchCookbook()
    {
        SceneManager.LoadScene(2);
    }
    
    //Go to Refrigerator
    public void SceneSwitchRefrigerator()
    {
        SceneManager.LoadScene(3);
    }
    
    //Go to Cabinet 1
    public void SceneSwitchCabinet1()
    {
        SceneManager.LoadScene(4);
    }
    
}
