using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedsButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text SeedCostTxt;
    public Text TreeQuantityTxt;
    public GameObject SeedsManager;

    void Update()
    {
        SeedCostTxt.text = BuildingShop.GetComponent<BuildingShop>().Seeds[2, ItemID].ToString();
        TreeQuantityTxt.text = BuildingShop.GetComponent<BuildingShop>().Seeds[3, ItemID].ToString();
    }
}
