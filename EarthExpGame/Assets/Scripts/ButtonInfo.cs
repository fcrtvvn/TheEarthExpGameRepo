using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text TreePriceTxt;
    public Text WaterPriceTxt;
    public GameObject BuildingShop;

    void Update()
    {
        TreePriceTxt.text = BuildingShop.GetComponent<BuildingShop>().shopBuildings[2, ItemID].ToString();
        WaterPriceTxt.text = BuildingShop.GetComponent<BuildingShop>().shopBuildings[3, ItemID].ToString();
    }
}
