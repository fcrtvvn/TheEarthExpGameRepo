//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Advertisements;


//public class AdManager : MonoBehaviour, IUnityAdsListener
//{
//    string placement = "rewardedVideo";

//    IEnumerator Start()
//    {
//        Advertisement.AddListener(this);
//        Advertisement.Initialize("4718631", true);

//        while (!Advertisement.IsReady(placement))
//            yield return null;

//        Advertisement.Show(placement);
//    }

//    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
//    {
//        throw new System.NotImplementedException();
//        //if (showResult == showResult.Finished)
//        //{
//        //    SeedsManager.Totalseeds++ =;
//        //}
//        //else if (showResult == showResult.Failed)
//        //{
//        //    //on no!
//        //}
//    }

//    public void OnUnityAdsDidError(string message)
//    {
//        throw new System.NotImplementedException();
//    }

//    public void OnUnityAdsDidStart(string placementId)
//    {
//        throw new System.NotImplementedException();
//    }

//    public void OnUnityAdsReady(string placementId)
//    {
//        throw new System.NotImplementedException();
//    }




//    //public interface IUnityAdsListener
//    //{

//    //}
//    ////public static bool IsReady(string placementId);

//    //void Start()
//    //{
//    //    Advertisement.Initialize("4718631");
//    //}

//    //public void PlayRewardedAd()
//    //{
//    //    if (Advertisement.IsReady("rewardedVideo"))
//    //    {
//    //        Advertisement.Show("rewardedVideo");
//    //    }
//    //    else
//    //    {
//    //        Debug.Log("Rewarded Ad not ready.");
//    //    }
//    //}


//}
