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
            return 1;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Settings.Instance.WeightUnits.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SettingsTableViewCell)tableView.DequeueReusableCell("SettingsTableViewCell");
            if (null == cell)
                cell = SettingsTableViewCell.Create();

            cell.TextLabel.Text = Settings.Instance.WeightUnits[indexPath.Row];

            return cell;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return "Weight Units";
        }
    }
}

