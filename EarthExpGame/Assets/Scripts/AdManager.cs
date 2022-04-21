using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsListener
{
    void Start()
    {
        Advertisement.Initialize("4718631");
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
        }
        else
        {
            Debug.Log("Rewarded Ad not ready.");
        }
    }

    public void OnUnityAdsReady(string placementID)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementID)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementID, ShowResult showResult)
    {
        throw new System.NotImplementedException();
    }
}
