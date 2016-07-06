using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace DemoNavigation
{
	public class SecondViewController : UIViewController
	{
		public SecondViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.View.BackgroundColor = UIColor.White;

			var label = new UILabel (new RectangleF (10, 40, 300, 30));
			label.Text = "Second View Controller";
			label.TextAlignment = UITextAlignment.Center;
			this.View.Add (label);

			var button = new UIButton (UIButtonType.Custom);
			button.SetTitle ("Move To Previous", UIControlState.Normal);
			button.SetTitleColor (UIColor.Blue, UIControlState.Normal);
			button.Frame = new RectangleF (10, 70, 200, 40);

			this.View.Add (button);
		}
	}
}

