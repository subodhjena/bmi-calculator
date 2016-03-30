// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

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
