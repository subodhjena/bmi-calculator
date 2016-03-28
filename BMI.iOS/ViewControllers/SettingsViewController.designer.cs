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
	[Register ("SettingsViewController")]
	partial class SettingsViewController
	{
		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("TappedDone:")]
		partial void TappedDone (Foundation.NSObject sender);

		[Action ("TappedShareWithOthers:")]
		partial void TappedShareWithOthers (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
