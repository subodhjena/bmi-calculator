using System;

using UIKit;
using Foundation;

namespace BMI.iOS
{
    public class SettingsTableViewDelegate : UITableViewDelegate
    {
        private SettingsViewController _settingsVC ;

        public SettingsTableViewDelegate(SettingsViewController settingsVC)
        {
            _settingsVC = settingsVC;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            Console.WriteLine("Row Selected At : "+ indexPath.Row);
            tableView.DeselectRow(indexPath, true);
        }
    }
}

