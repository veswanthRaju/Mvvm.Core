using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Mvvm.Droid
{
    [Activity(
        Label = "Mvvm.Droid"
        , MainLauncher = true //Because of this application will start with this Splash Screen
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash" //with this theme
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
