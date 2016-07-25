using UnityEngine;
using System.Collections;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class GoogleAdmobs : MonoBehaviour {

	private BannerView bannerView; //banner nhỏ	
	private InterstitialAd interstitial; //banner lớn (full màn hình)
	public Text wait_second;
	public void Start(){
		RequestBanner ();
		RequestInterstitial ();
		bannerView.Show ();
	}

	private void RequestBanner(){
		#if UNITY_EDITOR
			string adUnitId = "unused";
		#elif UNITY_ANDROID
			string adUnitId = "ca-app-pub-4098928031881049/6028132016"; 
		#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
			string adUnitId = "unexpected_platform";
		#endif 

		bannerView = new BannerView (adUnitId, AdSize.Banner, AdPosition.Bottom);
		AdRequest adrequest = new AdRequest.Builder ().Build ();
		bannerView.LoadAd (adrequest);
	}

	public void RequestInterstitial(){
		#if UNITY_EDITOR
			string adUnitId = "unused";
		#elif UNITY_ANDROID
			string adUnitId = "ca-app-pub-4098928031881049/7721531210";
		#elif (UNITY_5 && UNITY_IOS) || UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
			string adUnitId = "unexpected_platform";
		#endif

		interstitial = new InterstitialAd (adUnitId);
		AdRequest adrequest = new AdRequest.Builder ().Build ();
		interstitial.LoadAd (adrequest);

	}

		private void ShowInterstitial(){
		if (interstitial.IsLoaded ()) {
			interstitial.Show ();
		} 
			
	}	
	public void ShowIntel(){
		ShowInterstitial (); // nếu đã có thì show
	}	
	public void DestroyBanner(){
		bannerView.Destroy ();
	}
}
