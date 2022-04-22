using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuildingShop : MonoBehaviour
{
    public int[,] shopBuildings = new int[8, 8];
    public float trees;
    public Text TreeTXT;
    public float water;
    public Text WaterTXT;

    void Start()
    {
        TreeTXT.text = trees.ToString();
        WaterTXT.text = water.ToString();

        //IDs
        shopBuildings[1, 1] = 1;
        shopBuildings[1, 2] = 2;
        shopBuildings[1, 3] = 3;
        shopBuildings[1, 4] = 4;
        shopBuildings[1, 5] = 5;
        shopBuildings[1, 6] = 6;

        //Tree Cost
        shopBuildings[2, 1] = 50;
        shopBuildings[2, 2] = 90;
        shopBuildings[2, 3] = 125;
        shopBuildings[2, 4] = 180;
        shopBuildings[2, 5] = 200;
        shopBuildings[2, 6] = 220;

        //Water Cost
        shopBuildings[3, 1] = 150;
        shopBuildings[3, 2] = 270;
        shopBuildings[3, 3] = 375;
        shopBuildings[3, 4] = 540;
        shopBuildings[3, 5] = 600;
        shopBuildings[3, 6] = 660;
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
