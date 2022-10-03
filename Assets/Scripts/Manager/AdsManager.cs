using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    public GameObject AdsArePlaying;

    string id = "3629453";
    string myPlacementId = "rewardedVideo";


   public void Start(){
   
       Advertisement.Initialize (id, true);
       Advertisement.AddListener (this);
}
   public void StartAds(){
       Advertisement.Show (myPlacementId);
       Advertisement.Show ();
       AdsArePlaying.SetActive(true);
}

 public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // Reward the user for watching the ad to completion.
        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
        } else if (showResult == ShowResult.Failed) {
            
        }
    }

    public void OnUnityAdsReady (string placementId) {
        
    }

    public void OnUnityAdsDidError (string message) {
       
    }

    public void OnUnityAdsDidStart (string placementId) {
   
    } 
}
