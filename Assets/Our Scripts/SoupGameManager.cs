using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



//This file is used to handle most meta-events of the game, such
// as initializing all scenes.
public class SoupGameManager : MonoBehaviour
{
    public bool DebugMode;

    public static SoupGameManager control;
    public int PlayerScore=0;
    private float TimerSec=1.0f;
    private int TimerMin=0;
    private string Timer="";


    // Start is called before the first frame update
    void Start()
    {
        SceneManager.CreateScene("Cooking_Pot_Station");    // Scene 1
        SceneManager.CreateScene("Cookbook");   // Scene 2
        SceneManager.CreateScene("Refrigerator");   // Scene 3
        SceneManager.CreateScene("Cabinet_1");  // Scene 4
        //Do not need to createScene for Zoomed-out Overview, because
        // the game manager is located inside it in the first place
        //Zoomed-out Overview scene is Scene 0
    }

    // Ported from PotManager
    // Make Manager persist between scenes
    private void Awake()
    {
        // Let the gameObject persist over the scenes
        DontDestroyOnLoad(this);

        // Check if the control instance is null
        if (control == null)
        {
            // This instance becomes the single instance available
            control = this;
        }
        // *ADDED* Prevent duplicate managers from spawning
        //  when reentering the Kitchen Scene
        else {
            Destroy(gameObject);
        }

    }

    // Keeps track of countdown timer
    void Update()
    {
        if (TimerMin > -1)
        {
            Timer = TimerMin.ToString() + ":" + TimerSec.ToString("F0");
            if (TimerSec < 10) { Timer = TimerMin.ToString()+":0"+TimerSec.ToString("F0"); }
        }

        DebugModeLog(Timer);
        TimerSec -= Time.deltaTime;
        if (TimerSec <= 0.0f)
        {
            if (TimerMin == 0)
            {
                TimerEnded();
            }else{
                TimerMin -= 1;
                TimerSec += 59.0f;
            }
        }
        DebugModeLog(RecipeOrders.RecipeSeries[0].Ings[0]);
    }

    public string GetTimer()
    {
        return Timer;
    }

    //Called when the game timer reaches 0:00
    void TimerEnded()
    {
        DebugModeLog("TimerEnded()!");
        SoupGameManager.EndGame();
    }


    public static void SubmitSoup()
    {
        // Calculate Soup Score
        
        //Update Current Soup Score

        // Clear pot for next recipe
        PotManager.ClearPot();

        // Cycle to next recipe. End game if that was last recipe.
        if (RecipeOrders.NextRecipe())
        {
        }
    }


    public static void EndGame()
    {
        Debug.Log("Game ended. Go home.");
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
