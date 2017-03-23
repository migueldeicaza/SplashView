using System;

using UIKit;

using SplashView;
using System.Threading;

namespace SplashViewTest
{
	public partial class ViewController : UIViewController
	{
		//static string kTwitterIcon = @"twitterIcon";
		//static string kSnapchatIcon = @"snapchatIcon";

		static UIColor twitterColor = UIColor.FromRGB(0x44, 0x99, 0xFF);
		//static UIColor snapchatColor = UIColor.FromRGB(0xFF, 0xCC, 0x00);

		SplashView.SplashView splashView;

		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			//UIImage icon = UIImage.FromBundle ("twitterIcon");
			UIBezierPath bezier = BezierPaths.twitterShape;
			UIColor color = twitterColor;

			var sv = new SplashView.VectorSplashView(bezier, color);

			sv.AnimationDuration = 1.4f;

			View.AddSubview(sv);
  
  			this.splashView = sv;
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			ThreadPool.QueueUserWorkItem(delegate
			{
				Thread.Sleep(500);
				InvokeOnMainThread(() => { this.splashView.StartAnimation(); });
			});

		}

		public override bool PrefersStatusBarHidden()
		{
			return true;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
