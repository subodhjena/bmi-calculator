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
		UIKit.UITextField AgeTextField { get; set; }

		[Outlet]
		UIKit.UILabel BMIResultLabel { get; set; }

		[Outlet]
		UIKit.UIView Card1View { get; set; }

		[Outlet]
		UIKit.UIView Card2View { get; set; }

		[Outlet]
		UIKit.UITextField FeetTextField { get; set; }

		[Outlet]
		UIKit.UIImageView FemaleImage { get; set; }

		[Outlet]
		UIKit.UITextField InchesTextField { get; set; }

		[Outlet]
		UIKit.UIImageView MaleImage { get; set; }

		[Outlet]
		UIKit.UITextField NameTextField { get; set; }

		[Outlet]
		UIKit.UITextField WeightTextField { get; set; }

		[Action ("TappedOnSettings:")]
		partial void TappedOnSettings (Foundation.NSObject sender);

		[Action ("TappedShowResult:")]
		partial void TappedShowResult (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AgeTextField != null) {
				AgeTextField.Dispose ();
				AgeTextField = null;
			}

			if (BMIResultLabel != null) {
				BMIResultLabel.Dispose ();
				BMIResultLabel = null;
			}

			if (Card1View != null) {
				Card1View.Dispose ();
				Card1View = null;
			}

			if (Card2View != null) {
				Card2View.Dispose ();
				Card2View = null;
			}

			if (FeetTextField != null) {
				FeetTextField.Dispose ();
				FeetTextField = null;
			}

			if (FemaleImage != null) {
				FemaleImage.Dispose ();
				FemaleImage = null;
			}

			if (InchesTextField != null) {
				InchesTextField.Dispose ();
				InchesTextField = null;
			}

			if (MaleImage != null) {
				MaleImage.Dispose ();
				MaleImage = null;
			}

			if (NameTextField != null) {
				NameTextField.Dispose ();
				NameTextField = null;
			}

			if (WeightTextField != null) {
				WeightTextField.Dispose ();
				WeightTextField = null;
			}
		}
	}
}
