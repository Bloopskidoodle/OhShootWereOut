using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//This file is used to handle most meta-events of the game, such
// as initializing all scenes.
public class SoupGameManager : MonoBehaviour
{
    public static SoupGameManager control;


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

}
