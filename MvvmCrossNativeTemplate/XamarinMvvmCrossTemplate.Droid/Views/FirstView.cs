using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinMvvmCrossTemplate.Core.ViewModels;

namespace XamarinMvvmCrossTemplate.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class FirstView : MvxAppCompatActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.first_view);
        }
    }
}