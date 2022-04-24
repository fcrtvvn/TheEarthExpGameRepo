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

    BuildingShop buildingShop = BuildingShop.Find("TreeTXT");

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
        Seeds[2, 1] = 3;
        Seeds[2, 2] = 6;
        Seeds[2, 3] = 9;
        Seeds[2, 4] = 12;
        Seeds[2, 5] = 15;
        Seeds[2, 6] = 18;

        //Add Tree
        Seeds[3, 1] = 9;
        Seeds[3, 2] = 18;
        Seeds[3, 3] = 27;
        Seeds[3, 4] = 36;
        Seeds[3, 5] = 45;
        Seeds[3, 6] = 54;
    }

    //IEnumerator PlantCoroutine()
    //

    public void UseSeeds()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (seedcost >= Seeds[2, ButtonRef.GetComponent<SeedsButtonInfo>().ItemID])
        {
            seedcost -= Seeds[2, ButtonRef.GetComponent<SeedsButtonInfo>().ItemID];
            Seeds[3, buildingShop.TreeTXT.ItemID] *= 3; 
            SeedTXT.text = seedcost.ToString();
            buildingShop.TreeTXT = Seeds[3, buildingShop.TreeTXT.ItemID].ToString();
        }
        //else 
    }
}
