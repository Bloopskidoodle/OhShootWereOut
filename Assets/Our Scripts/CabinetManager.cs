using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabinetManager : MonoBehaviour
{
    public Button CandyCornButton;
    public Button PieSliceButton;
    public Button DoritoButton;
    public Button PotatoChipButton;
    public Button PotatoButton;
    public Button SpiderButton;
    public Button PumpkinButton;
    public Button MoldyBreadButton;
    public Button SaltedChocoCaramelButton;
    public Button BloodPackButton;
    public Button SaltButton;
    public Button NoodleBrickButton;

    private void Awake()
    {
        CandyCornButton.onClick.AddListener(AddCandyCorn);
        PieSliceButton.onClick.AddListener(AddPieSlice);
        DoritoButton.onClick.AddListener(AddDorito);
        PotatoChipButton.onClick.AddListener(AddPotatoChip);
        PotatoButton.onClick.AddListener(AddPotato);
        SpiderButton.onClick.AddListener(AddSpider);
        PumpkinButton.onClick.AddListener(AddPumpkin);
        MoldyBreadButton.onClick.AddListener(AddMoldyBread);
        SaltedChocoCaramelButton.onClick.AddListener(AddSaltedChocoCaramel);
        BloodPackButton.onClick.AddListener(AddBloodPack);
        SaltButton.onClick.AddListener(AddSalt);
        NoodleBrickButton.onClick.AddListener(AddNoodleBrick);
    }

    public void AddCandyCorn()
    {
        PotManager.candy_corn += 1;
        Debug.Log("Candy Corn x1 added to pot.");
        Debug.LogFormat("There are {0} candy corn in the pot.", PotManager.candy_corn);
    }

    public void AddPieSlice()
    {
        PotManager.pie_slice += 1;
        Debug.Log("Pie Slice x1 added to pot.");
        Debug.LogFormat("There are {0} slices of pie in the pot.", PotManager.pie_slice);
    }

    public void AddDorito()
    {
        PotManager.dorito += 1;
        Debug.Log("Dorito x1 added to pot.");
        Debug.LogFormat("There are {0} doritos in the pot.", PotManager.dorito);
    }

    public void AddPotatoChip()
    {
        PotManager.potato_chip += 1;
        Debug.Log("Potato Chi[ x1 added to pot.");
        Debug.LogFormat("There are {0} potato chips in the pot.", PotManager.potato_chip);
    }

    public void AddPotato()
    {
        PotManager.potato += 1;
        Debug.Log("Potato x1 added to pot.");
        Debug.LogFormat("There are {0} potatoes in the pot.", PotManager.potato);
    }

    public void AddSpider()
    {
        PotManager.spider += 1;
        Debug.Log("Spider x1 added to pot.");
        Debug.LogFormat("There are {0} spiders in the pot.", PotManager.spider);
    }

    public void AddPumpkin()
    {
        PotManager.pumpkin += 1;
        Debug.Log("Pumkpin x1 added to pot.");
        Debug.LogFormat("There are {0} pumpkins in the pot.", PotManager.pumpkin);
    }

    public void AddMoldyBread()
    {
        PotManager.moldy_bread += 1;
        Debug.Log("Moldy Bread x1 added to pot.");
        Debug.LogFormat("There are {0} loaves of moldy bread in the pot.", PotManager.moldy_bread);
    }

    public void AddSaltedChocoCaramel()
    {
        PotManager.salted_choco_caramel += 1;
        Debug.Log("Salted Chocolate Caramel x1 added to pot.");
        Debug.LogFormat("There are {0} salted chocolate caramels in the pot.", PotManager.salted_choco_caramel);
    }

    public void AddBloodPack()
    {
        PotManager.blood_pack += 1;
        Debug.Log("Blood Pack x1 added to pot.");
        Debug.LogFormat("There are {0} packs of blood in the pot.", PotManager.blood_pack);
    }

    public void AddSalt()
    {
        PotManager.salt += 1;
        Debug.Log("Salt x1 added to pot.");
        Debug.LogFormat("There are {0} spoons of salt in the pot.", PotManager.salt);
    }

    public void AddNoodleBrick()
    {
        PotManager.noodle_brick += 1;
        Debug.Log("Noodle Brick x1 added to pot.");
        Debug.LogFormat("There are {0} noodle bricks in the pot.", PotManager.noodle_brick);
    }
}
