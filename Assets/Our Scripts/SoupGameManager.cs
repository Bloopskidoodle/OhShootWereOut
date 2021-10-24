using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//This file is used to handle most meta-events of the game, such
// as initializing all scenes.
public class SoupGameManager : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
