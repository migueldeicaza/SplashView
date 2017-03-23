using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using System.Threading.Tasks;
using System.Threading;

namespace SplashView
{
	public class VectorSplashView : SplashView
	{
		public UIColor BackgroundViewColor { get; set; }
		public CAShapeLayer IconLayer { get; set; }

		public VectorSplashView (UIBezierPath bezierPath, UIColor backgroundColor) : base (UIScreen.MainScreen.Bounds)
		{
			BackgroundViewColor = backgroundColor;
			IconLayer = CreateShapeLayerWithBezierPath (bezierPath);

			this.Layer.AddSublayer(IconLayer);
			this.BackgroundColor = this.IconColor;
		}

		CAShapeLayer CreateShapeLayerWithBezierPath (UIBezierPath bezierPath)
		{
			/* Expand the shape bounds, so when it scales down a bit in the beginning, we have some padding */
			var shapeBounds = Bounds.Inset (-Bounds.Width, -Bounds.Height);

			using (var mutablePath = new CGPath ()) {
				mutablePath.AddRect (shapeBounds);

				/* Move the icon to the middle */
				var iconOffset = new CGPoint ((Bounds.Width - bezierPath.Bounds.Width) / 2,
							      (Bounds.Height - bezierPath.Bounds.Height) / 2);

				var iconTransform = CGAffineTransform.MakeTranslation (iconOffset.X, iconOffset.Y);

				mutablePath.AddPath (iconTransform, bezierPath.CGPath);

				var shapeLayer = (CAShapeLayer) CAShapeLayer.Create ();
				shapeLayer.Bounds = shapeBounds;
				shapeLayer.Position = new CGPoint (Bounds.Width / 2, Bounds.Height / 2);
				shapeLayer.Path = mutablePath;
				shapeLayer.AnchorPoint = new CGPoint (0.5, 0.5);
				shapeLayer.FillColor = BackgroundViewColor.CGColor;

				return shapeLayer;
			}
		}

		Action animationCompletionHandler;
		public override void StartAnimation (Action onComplete = null)
		{
			animationCompletionHandler = onComplete;
			IconAnimation.Delegate = new MyAnimationCallback (this);
			IconLayer.AddAnimation (IconAnimation, "VectorSplashViewAnimation");
			ThreadPool.QueueUserWorkItem (delegate {
				Thread.Sleep ((int)(AnimationDuration * 0.4f));
				InvokeOnMainThread (() => { BackgroundColor = UIColor.Clear; });
			});
		}

		class MyAnimationCallback : CAAnimationDelegate
		{
			WeakReference<VectorSplashView> wparent;

			public MyAnimationCallback (VectorSplashView parent)
			{
				wparent = new WeakReference<VectorSplashView> (parent);
			}

			public override void AnimationStopped (CAAnimation anim, bool finished)
			{
				VectorSplashView parent;

				wparent.TryGetTarget (out parent);
				if (parent.animationCompletionHandler != null)
					parent.animationCompletionHandler ();
				parent.RemoveFromSuperview ();
			}
		}

	}
}
