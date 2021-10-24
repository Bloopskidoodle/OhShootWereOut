using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotManager : MonoBehaviour
{
    public static PotManager control;

    // Items in Refrigerator
    public static int cheese = 0;
    public static int carrot = 0;
    public static int fish_tail = 0;
    public static int lemon = 0;
    public static int tomato = 0;
    public static int egg = 0;
    public static int m_meat = 0;
    public static int lettuce = 0;
    public static int bell_pepper = 0;
    public static int ice_cube = 0;
    public static int human_finger = 0;
    public static int tears_of_enemy = 0;

    // Items in Cabinet
    public static int candy_corn = 0;
    public static int pie_slice = 0;
    public static int dorito = 0;
    public static int potato_chip = 0;
    public static int potato = 0;    
    public static int spider = 0;
    public static int pumpkin = 0;
    public static int moldy_bread = 0;
    public static int salted_choco_caramel = 0;
    public static int blood_pack = 0;
    public static int salt = 0;
    public static int noodle_brick = 0;
    

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
        cheese = 0;
        carrot = 0;
        fish_tail = 0;
        lemon = 0;
        tomato = 0;
        egg = 0;;
        m_meat = 0;
        lettuce = 0;
        bell_pepper = 0;
        ice_cube = 0;
        human_finger = 0;
        tears_of_enemy = 0;

        candy_corn = 0;
        pie_slice = 0;
        dorito = 0;
        potato_chip = 0;
        potato = 0;    
        spider = 0;
        pumpkin = 0;
        moldy_bread = 0;
        salted_choco_caramel = 0;
        blood_pack = 0;
        salt = 0;
        noodle_brick = 0;
    }
}
