using System;
using UIKit;

namespace XamarinMvvmCrossTemplate.iOS
{
    public class Application
    {
        static void Main(string[] args)
        {
            try
            {
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
