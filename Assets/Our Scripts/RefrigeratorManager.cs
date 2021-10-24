using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefrigeratorManager : MonoBehaviour
{
    public Button CarrotButton;

    private void Awake()
    {
        CarrotButton.onClick.AddListener(AddCarrot);
    }

    public void AddCarrot()
    {
        /// <summary>
        /// Increments the number of carrots to PotManager.
        /// </summary>
        PotManager.carrot += 1;


        Debug.Log("Carrot x1 added to pot.");
        Debug.LogFormat("There are {0} carrots in the pot.", PotManager.carrot);
    }
}
