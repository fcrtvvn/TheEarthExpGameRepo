using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SeedsManager : MonoBehaviour
{
    public int[,] Seeds = new int[8, 8];
    public float seeds;
    public Text SeedsTXT;
    public float tree;
    public Text TreeTXT;

    void Start()
    {
        SeedsTXT.text = seeds.ToString();
        TreeTXT.text = tree.ToString();

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

        //Tree Quantity
        Seeds[3, 1] = 9;
        Seeds[3, 2] = 18;
        Seeds[3, 3] = 24;
        Seeds[3, 4] = 36;
        Seeds[3, 5] = 45;
        Seeds[3, 6] = 54;
    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (trees >= shopBuildings[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            trees -= shopBuildings[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            TreeTXT.text = trees.ToString();
        }

        if (water >= shopBuildings[3, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            water -= shopBuildings[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            WaterTXT.text = water.ToString();
        }


    }
}
//9 18 27 36 45 63