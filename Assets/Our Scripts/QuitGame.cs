using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{

    public static QuitGame control; // static reference
    public Button QuitButton;

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
        else
        {
            Destroy(gameObject);
        }

        QuitButton.onClick.AddListener(Quit);
    }

    public static void Quit() { SceneManager.LoadScene("End_Game"); }
}
