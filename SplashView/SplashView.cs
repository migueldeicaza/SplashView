using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace SplashView
{
	public abstract class SplashView : UIView
	{
		internal SplashView (CGRect frame) : base (UIScreen.MainScreen.Bounds)
		{
		}

		public abstract void StartAnimation (Action onComplete = null);

		public CGSize IconStartSize { get; } = new CGSize (60, 60);
		public nfloat AnimationDuration { get; } = 1f;

		CAKeyFrameAnimation iconAnimation;
		public CAAnimation IconAnimation {
			get {
				if (iconAnimation == null) {
					iconAnimation = CAKeyFrameAnimation.FromKeyPath ("transform.scale");
					iconAnimation.Values = new NSObject [] { NSNumber.FromFloat (1), NSNumber.FromFloat (0.9f), NSNumber.FromFloat (300) };
					iconAnimation.KeyTimes = new NSNumber [] { NSNumber.FromFloat (0), NSNumber.FromFloat (0.4f), NSNumber.FromFloat (1) };
					iconAnimation.Duration = AnimationDuration;
					iconAnimation.RemovedOnCompletion = false;
					iconAnimation.FillMode = CAFillMode.Forwards;
					iconAnimation.TimingFunctions = new CAMediaTimingFunction [] {
						CAMediaTimingFunction.FromName (CAMediaTimingFunction.EaseOut),
						CAMediaTimingFunction.FromName (CAMediaTimingFunction.EaseIn)
					};

				}
				return iconAnimation;
			}
		}
		public UIColor IconColor { get; set; } = UIColor.White;
	}
}
