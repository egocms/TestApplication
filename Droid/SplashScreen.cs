using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace TestApplication.Droid
{
	[Activity (
		Label = "TestApplication.Droid"
		, MainLauncher = true
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen ()
			: base (Resource.Layout.SplashScreen)
		{
		}
	}
}