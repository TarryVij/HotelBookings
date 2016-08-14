using Foundation;
using System;
using UIKit;

namespace DeakinOpenDay
{
	public partial class TableViewController : UITableViewController
	{
		public TableViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "BasicRooms,", "2StarRooms", "3StarRooms", "5StarRooms", "HoneymoonSuits", };
			TableData.Source = new TableSource(items, this);
		}
	}
}