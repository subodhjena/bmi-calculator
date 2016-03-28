using System;
using System.Collections;

using UIKit;
using Foundation;

using BMI.Core.Helpers;

namespace BMI.iOS
{
    public class SettingsTableViewSource : UITableViewSource
    {
        public SettingsTableViewSource()
        {
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            if (section == 0)
            {
                return Settings.Instance.WeightUnits.Count;
            }

            return 5;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SettingsTableViewCell) tableView.DequeueReusableCell("SettingsTableViewCell");
            if (null == cell)
                cell = SettingsTableViewCell.Create();

            if (indexPath.Section == 0)
            {
                cell.TextLabel.Text = Settings.Instance.WeightUnits[indexPath.Row];
            }

            return cell;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return "Weight Units";
            }

            return "Other Settings";
        }
    }
}

