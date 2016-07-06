using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace DemoNavigation
{
	public class FirstViewController : UIViewController
	{
		public FirstViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.View.BackgroundColor = UIColor.White;
			this.NavigationController.NavigationBarHidden = false;
			this.Title = "First View Controller";

			var label = new UILabel (new RectangleF (10, 40, 300, 30));
			label.Text = "First View Controller";
			label.TextAlignment = UITextAlignment.Center;
			this.View.Add (label);

			var button = new UIButton (UIButtonType.Custom);
			button.SetTitle ("Move To Next", UIControlState.Normal);
			button.SetTitleColor (UIColor.Blue, UIControlState.Normal);
			button.TouchUpInside += (object sender, EventArgs e) => {
				this.NavigationController.PushViewController (new SecondViewController (), true);
			};
			button.Frame = new RectangleF (10, 70, 200, 40);

			this.View.Add (button);
		}
	}
}

