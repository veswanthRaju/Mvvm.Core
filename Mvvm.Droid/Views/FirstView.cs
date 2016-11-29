using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;

namespace Mvvm.Droid.Views
{
    /// <summary>
    ///Recognise its ViewModel by its name only
    /// Eg: FisrtView For FirstViewModel
    /// If Name is different then we can use this arttribute
    /// [MvxViewFor(typeof(FirstViewModel))]
    /// </summary>
    [Activity(Label = "View for FirstViewModel")]
    //[MvxViewFor(typeof(FirstViewModel))]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
