using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Collections;

namespace DailyRewardSystem
{
    public enum RewardType
    {
        Seeds
    }
    [Serializable] public struct Reward
    {
        public RewardType Type;
        public int Amount;
    }

    public class DailyRewards : MonoBehaviour
    {

        [Header("Mainpanel")]
        [SerializeField] Text seedsText;

        //[Space]
        //[Header("REWARDS")]

        void Start()
        {
            Initialize();
        }

        void Initialize()
        {
            //Update REWARDS (Totalseeds)
            UpdateTotalSeeds();
        }

        //Update REWARDS (Totalseeds)-------------
        void UpdateTotalSeeds()
        {
            seedsText.text = GameData.Totalseeds.ToString();
        }
    }

}


   
