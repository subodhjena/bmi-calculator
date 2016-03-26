using System;

using UIKit;
using Foundation;

namespace BMI.iOS
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController(IntPtr handle)
            : base(handle)
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

        partial void TappedShowResults(NSObject sender)
        {
        }
    }
}

