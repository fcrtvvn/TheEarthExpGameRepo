using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedsButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text SeedCostTxt;
    public GameObject SeedsShop;

    void Update()
    {
        SeedCostTxt.text = SeedsShop.GetComponent<SeedsShop>().Seeds[2, ItemID].ToString();
    }
}
