using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefrigeratorManager : MonoBehaviour
{
    public Button CheeseButton;
    public Button CarrotButton;
    public Button FishTailButton;
    public Button LemonButton;
    public Button TomatoButton;
    public Button EggButton;
    public Button MMeatButton;
    public Button LettuceButton;
    public Button BellPepperButton;
    public Button IceCubeButton;
    public Button HumanFingerButton;
    public Button TearOfEnemyButton;
    

    private void Start()
    {
        CheeseButton.onClick.AddListener(AddCheese);
        CarrotButton.onClick.AddListener(AddCarrot);
        FishTailButton.onClick.AddListener(AddFishTail);
        LemonButton.onClick.AddListener(AddLemon);
        TomatoButton.onClick.AddListener(AddTomato);
        EggButton.onClick.AddListener(AddEgg);
        MMeatButton.onClick.AddListener(AddMMeat);
        LettuceButton.onClick.AddListener(AddLettuce);
        BellPepperButton.onClick.AddListener(AddBellPepper);
        IceCubeButton.onClick.AddListener(AddIceCube);
        HumanFingerButton.onClick.AddListener(AddHumanFinger);
        TearOfEnemyButton.onClick.AddListener(AddTearOfEnemy);
    }

    public void AddCheese()
    {
        PotManager.cheese += 1;
        Debug.Log("Cheese x1 added to pot.");
        Debug.LogFormat("There are {0} pieces of cheese in the pot.", PotManager.cheese);
    }
    public void AddCarrot() {
        PotManager.carrot += 1;
        Debug.Log("Carrot x1 added to pot.");
        Debug.LogFormat("There are {0} carrots in the pot.", PotManager.carrot);
    }
    public void AddFishTail() {
        PotManager.fish_tail += 1;
        Debug.Log("Fish Tail x1 added to pot.");
        Debug.LogFormat("There are {0} fish tails in the pot.", PotManager.fish_tail);
    }

    public void AddLemon()
    {
        PotManager.lemon += 1;
        Debug.Log("Lemon x1 added to pot.");
        Debug.LogFormat("There are {0} lemons in the pot.", PotManager.lemon);
    }

    public void AddTomato()
    {
        PotManager.tomato += 1;
        Debug.Log("Tomato x1 added to pot.");
        Debug.LogFormat("There are {0} tomatoes in the pot.", PotManager.tomato);
    }

    public void AddEgg()
    {
        PotManager.egg += 1;
        Debug.Log("Egg x1 added to pot.");
        Debug.LogFormat("There are {0} eggs in the pot.", PotManager.egg);
    }

    public void AddMMeat()
    {
        PotManager.m_meat += 1;
        Debug.Log("Meat(?) x1 added to pot.");
        Debug.LogFormat("There are {0} pieces of meat(?) in the pot.", PotManager.m_meat);
    }

    public void AddLettuce()
    {
        PotManager.lettuce += 1;
        Debug.Log("Lettuce x1 added to pot.");
        Debug.LogFormat("There are {0} pieces of lettuce in the pot.", PotManager.lettuce);
    }

    public void AddBellPepper()
    {
        PotManager.bell_pepper += 1;
        Debug.Log("Bell Pepper x1 added to pot.");
        Debug.LogFormat("There are {0} bell peppers in the pot.", PotManager.bell_pepper);
    }

    public void AddIceCube()
    {
        PotManager.ice_cube += 1;
        Debug.Log("Ice Cube x1 added to pot.");
        Debug.LogFormat("There are {0} ice cubes in the pot.", PotManager.ice_cube);
    }

    public void AddHumanFinger()
    {
        PotManager.human_finger += 1;
        Debug.Log("Human Finger x1 added to pot.");
        Debug.LogFormat("There are {0} human fingers in the pot.", PotManager.human_finger);
    }

    public void AddTearOfEnemy()
    {
        PotManager.tears_of_enemy += 1;
        Debug.Log("Tear of Enemy x1 added to pot.");
        Debug.LogFormat("There are {0} tears of enemies in the pot.", PotManager.tears_of_enemy);
    }

}
