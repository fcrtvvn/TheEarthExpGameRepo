using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedsButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text SeedCostTxt;
    public GameObject SeedsManager;

    void Update()
    {
        SeedCostTxt.text = BuildingShop.GetComponent<SeedsManager>().Seeds[2, ItemID].ToString();
    }
}
