using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotManager : MonoBehaviour
{
    public static PotManager control;

    // Data to persist
    public static int carrots = 0;
    // Add more items later

    private void Awake()
    {
        // Let the gameObject persist over the scenes
        DontDestroyOnLoad(gameObject);

        // Check if the control instance is null
        if (control == null)
        {
            // This instance becomes the single instance available
            control = this;
        }
    }

    public void ClearPot()
    {
        /// <summary>
        /// Set all ingredients to 0.
        /// </summary>
        /// 
        carrots = 0;
        // Remember to add items later
    }
}
