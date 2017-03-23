using System;
using UIKit;
using CoreGraphics;

namespace SplashView
{
	public class RasterSplashView :  SplashView
	{
		UIImageView iconImageView;

		public RasterSplashView (UIImage icon, UIColor backgroundColor) : base (UIScreen.MainScreen.Bounds)
		{
			BackgroundColor = backgroundColor;
			iconImageView = new UIImageView () {
				Image = icon.ImageWithRenderingMode (UIImageRenderingMode.AlwaysTemplate),
				TintColor = IconColor,
				Frame = new CGRect (new CGPoint (0, 0), IconStartSize),
				ContentMode = UIViewContentMode.ScaleAspectFit,
				Center = Center
			};
			AddSubview (iconImageView);
		}

		public void SetIconStartSize (CGSize iconStartSize)
		{
			SetIconStartSize (iconStartSize);
			iconImageView.Frame = new CGRect (CGPoint.Empty, iconStartSize.ToRoundedCGSize());
			iconImageView.Center = Center;
		}

		public override void StartAnimation (Action onComplete = null)
		{
			if (AnimationDuration < 0)
				return;

			nfloat shrinkDuration = AnimationDuration * 0.3f;
			nfloat growDuration = AnimationDuration * 0.7f;

			UIView.AnimateNotify (
				duration: shrinkDuration,
				delay: 0,
				springWithDampingRatio: 0.7f,
				initialSpringVelocity: 10,
				options: UIViewAnimationOptions.CurveEaseInOut,
				animations: () => {
					var scaleTransform = CGAffineTransform.MakeScale (0.75f, 0.75f);
					iconImageView.Transform = scaleTransform;
				}, completion: (bool finished) => {
					UIView.AnimateNotify (growDuration, () => {
						var scaleTransform = CGAffineTransform.MakeScale (20, 20);
						iconImageView.Transform = scaleTransform;
						Alpha = 0;
					}, completion: (bool finish2) => {
						RemoveFromSuperview ();
						if (onComplete != null) onComplete ();
					});
				});
		}
	}
}
