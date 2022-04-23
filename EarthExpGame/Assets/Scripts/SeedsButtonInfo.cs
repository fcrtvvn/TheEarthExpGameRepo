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
        SeedCostTxt.text = SeedsManager.GetComponent<SeedsManager>().Seeds[2, ItemID].ToString();
        TreeQuantityTxt.text = SeedsManager.GetComponent<SeedsManager>().Seeds[3, ItemID].ToString();
    }
}
