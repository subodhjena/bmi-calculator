using System;

using Foundation;
using UIKit;

namespace BMI.iOS
{
    public partial class SettingsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SettingsTableViewCell");
        public static readonly UINib Nib;

        static SettingsTableViewCell()
        {
            Nib = UINib.FromName("SettingsTableViewCell", NSBundle.MainBundle);
        }

        public SettingsTableViewCell(IntPtr handle)
            : base(handle)
        {
        }

        public static SettingsTableViewCell Create()
        {
            return (SettingsTableViewCell) Nib.Instantiate(null, null)[0];
        }
    }
}
