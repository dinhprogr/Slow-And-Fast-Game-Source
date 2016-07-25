using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.
using Facebook.Unity;
public class ShareFB : MonoBehaviour {
	string fbAppUrl = "http://www.facebook.com/dialog/feed";
	public string fbAppid;
	void Awake ()
	{
		if (!FB.IsInitialized) {
			// Initialize the Facebook SDK
			FB.Init(InitCallback, OnHideUnity);
		} else {
			// Already initialized, signal an app activation App Event
			FB.ActivateApp();
		}
	}
	
	private void InitCallback ()
	{
		if (FB.IsInitialized) {
			// Signal an app activation App Event
			FB.ActivateApp();
			// Continue with Facebook SDK
			// ...
		} 
	}
	
	private void OnHideUnity (bool isGameShown)
	{
		if (!isGameShown) {
			// Pause the game - we will need to hide
			Time.timeScale = 0;
		} else {
			// Resume the game - we're getting focus again
			Time.timeScale = 1;
		}
	}

	public List<string> perms =new List<string>(){"public_profile", "email", "user_friends"};
	private void AuthCallback (ILoginResult result) {
		LogInWithReadPermissions(perms, AuthCallback);
		if (FB.IsLoggedIn) {
			// AccessToken class will have session details
			var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
			// Print current access token's User ID
			// Print current access token's granted permissions
			foreach (string perm in aToken.Permissions) {
				Debug.Log(perm);
			}
		} else {
			Debug.Log("User cancelled login");
		}
	}
	public static void LogInWithReadPermissions (IEnumerable<string> LogInWithReadPermissions, FacebookDelegate<ILoginResult> callback){}

	public void ShareFBcheck(string linkParameter,string nameParameter,string captionParameter,string descriptionParameter,string pictureParameter,string redirectParameter) {

		Application.OpenURL(fbAppUrl + "?app_id=" + fbAppid + "&link=" + WWW.EscapeURL(linkParameter) + "&name=" + WWW.EscapeURL(nameParameter)
		                    + "&caption=" + WWW.EscapeURL(captionParameter) + "&description=" + WWW.EscapeURL(descriptionParameter) 
		                    + "&picture=" + WWW.EscapeURL(pictureParameter) + "&redirect_uri=" + WWW.EscapeURL(redirectParameter));
		FB.FeedShare(linkCaption:"Hãy thử ngay!",linkName:"Tôi đang chơi game này");
	}
	public void shareFb() {
		ShareFBcheck ("Facebook.com","SpeedControl","Tôi đang chơi game này !","Cực kỳ dễ dàng !",null,null);
	}

}
