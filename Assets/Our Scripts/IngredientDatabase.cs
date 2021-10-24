using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDatabase : MonoBehaviour
{
    // db database
    // key : value
    // <ingredient> : < [sweet, sour, salt, shape] >
    //  triangle = 0, circle = 1, square = 2 for now
    private Dictionary<string, int[]> db =
        new Dictionary<string, int[]>();

    void Start()
    {                               // SwSrSlSh
        // Triangles
        db.Add("cheese",        new[] {1,0,3,0});
        db.Add("carrot",        new[] {3,0,2,0});
        db.Add("human_fingers", new[] {1,1,1,0});
        db.Add("candy_corn",    new[] {2,1,0,0});
        db.Add("slice_of_pie",  new[] {2,0,0,0});
        db.Add("fish_tail",     new[] {0,2,1,0});
        db.Add("dorito",        new[] {0,2,3,0});
        db.Add("tear",          new[] {0,1,3,0}); // Shortened name from "Tears of My Enemies"
        // Circles
        db.Add("potato_chips",  new[] {2,0,3,1});
        db.Add("potato",        new[] {1,0,2,1});
        db.Add("lemon",         new[] {2,3,0,1});
        db.Add("tomato",        new[] {2,2,1,1});
        db.Add("egg",           new[] {3,0,1,1});
        db.Add("lettuce",       new[] {3,1,0,1});
        db.Add("spider",        new[] {0,3,2,1});
        db.Add("pumpkin",       new[] {2,1,0,1});
        // Squares
        db.Add("bell_pepper",   new[] {3,1,1,2});
        db.Add("meat",          new[] {0,1,2,2}); // Shorterned name from "Meat(?)"
        db.Add("moldy_bread",   new[] {1,3,1,2});
        db.Add("chocolate",     new[] {3,0,1,2}); // Shortened name from "Salted Chocolate Caramel"
        db.Add("blood",         new[] {0,1,3,2}); // Shortened name from "Blood Pack 'Ketchup'"
        db.Add("salt",          new[] {0,0,3,2});
        db.Add("noodle_brick",  new[] {0,2,3,2});
        db.Add("ice_cube",      new[] {0,0,0,2});
    }

    public int[] Get(string s)
    {
        int[] v;
        if ( db.TryGetValue(s, out v) )
        {
            return v;
        }else{
            Debug.Log("ERROR: Ingredient entry for: \""+s+"\" not found!");
            return new int[0];
        }
    }
}
