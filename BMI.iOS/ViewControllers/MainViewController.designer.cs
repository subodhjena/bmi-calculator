// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BMI.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIImageView imgFemale { get; set; }

		[Outlet]
		UIKit.UIImageView imgMale { get; set; }

		[Outlet]
		UIKit.UILabel lblBMIValue { get; set; }

		[Outlet]
		UIKit.UITextField txtAge { get; set; }

		[Outlet]
		UIKit.UITextField txtFeet { get; set; }

		[Outlet]
		UIKit.UITextField txtInches { get; set; }

		[Outlet]
		UIKit.UITextField txtName { get; set; }

		[Outlet]
		UIKit.UITextField txtWeight { get; set; }

		[Outlet]
		UIKit.UIView viewCard1 { get; set; }

		[Outlet]
		UIKit.UIView viewCard2 { get; set; }

		[Action ("TappedShowResults:")]
		partial void TappedShowResults (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (imgFemale != null) {
				imgFemale.Dispose ();
				imgFemale = null;
			}

			if (imgMale != null) {
				imgMale.Dispose ();
				imgMale = null;
			}

			if (lblBMIValue != null) {
				lblBMIValue.Dispose ();
				lblBMIValue = null;
			}

			if (txtAge != null) {
				txtAge.Dispose ();
				txtAge = null;
			}

			if (txtFeet != null) {
				txtFeet.Dispose ();
				txtFeet = null;
			}

			if (txtInches != null) {
				txtInches.Dispose ();
				txtInches = null;
			}

			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (txtWeight != null) {
				txtWeight.Dispose ();
				txtWeight = null;
			}

			if (viewCard1 != null) {
				viewCard1.Dispose ();
				viewCard1 = null;
			}

			if (viewCard2 != null) {
				viewCard2.Dispose ();
				viewCard2 = null;
			}
		}
	}
}
