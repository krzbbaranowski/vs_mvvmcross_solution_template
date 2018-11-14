rm *.nupkg

mono ./nuget.exe pack ./MvvmCrossTemplate.nuspec

mv ./KrzB.MvvmCross.Xamarin.Template.CSharp.Native.iOS.Android.*.nupkg KrzB.MvvmCross.Xamarin.Template.CSharp.Native.iOS.Android.nupkg