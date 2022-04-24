using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SeedsShop : MonoBehaviour
{
    public int[,] Seeds = new int[8, 8];
    public float seedcost;
    public Text SeedTXT;

    void Start()
    {
        SeedTXT.text = seedcost.ToString();

        //IDs
        Seeds[1, 1] = 1;
        Seeds[1, 2] = 2;
        Seeds[1, 3] = 3;
        Seeds[1, 4] = 4;
        Seeds[1, 5] = 5;
        Seeds[1, 6] = 6;

        //Seed Cost

    }
}
