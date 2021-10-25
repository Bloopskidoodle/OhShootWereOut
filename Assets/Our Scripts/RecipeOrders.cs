using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Keep track of all Orders and associated Recipes
public class RecipeOrders : MonoBehaviour
{
    public static RecipeOrders control;
    public static int RecipeNumberIndex;
    public struct Recipe
    {
        public List<string> Ings;
    }

    public static Recipe[] RecipeSeries = new Recipe [3];
    // public static Recipe DiabeticSoup;
    // public static Recipe EggSoup;
    // public static Recipe Ramen;

    void Start()
    {
        RecipeNumberIndex = 0;

        Recipe DiabeticSoup;
        DiabeticSoup.Ings = new List<string>();
        DiabeticSoup.Ings.Add("chocolate");
        DiabeticSoup.Ings.Add("pumpkin");
        DiabeticSoup.Ings.Add("candy_corn");
        RecipeSeries[0] = DiabeticSoup;
        
        Recipe EggSoup;
        EggSoup.Ings = new List<string>();
        EggSoup.Ings.Add("potato");
        EggSoup.Ings.Add("carrot");
        EggSoup.Ings.Add("egg");
        RecipeSeries[1] = EggSoup;

        Recipe Ramen;
        Ramen.Ings = new List<string>();
        Ramen.Ings.Add("tear");
        Ramen.Ings.Add("noodle_brick");
        Ramen.Ings.Add("meat");
        RecipeSeries[2] = Ramen;
    }

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

    public static bool NextRecipe()
    {
        RecipeNumberIndex++;
        if (RecipeNumberIndex == RecipeSeries.Length)
        {
            return false;
        }else{
            return true;
        }
    }
}
