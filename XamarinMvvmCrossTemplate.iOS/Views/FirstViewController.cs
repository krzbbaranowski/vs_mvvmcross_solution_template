﻿using System;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using XamarinMvvmCrossTemplate.Core.ViewModels;

namespace XamarinMvvmCrossTemplate.iOS.Views
{
    public partial class FirstViewController : MvxViewController<FirstViewModel>
    {
        public FirstViewController() : base("FirstViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

