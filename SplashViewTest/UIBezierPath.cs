using System;
using CoreGraphics;
using UIKit;

namespace SplashViewTest
{
	public class BezierPaths
	{
		public static UIBezierPath twitterShape
		{
			get
			{
				UIBezierPath nPath = new UIBezierPath();
				nPath.MoveTo(new CGPoint(22.05, 56.63));

				nPath.AddCurveToPoint(new CGPoint(34.23, 54.93), new CGPoint(26.32, 56.63), new CGPoint(30.38, 56.06));
				nPath.AddCurveToPoint(new CGPoint(44.42, 50.27), new CGPoint(38.08, 53.8), new CGPoint(41.48, 52.25));
				nPath.AddCurveToPoint(new CGPoint(52.37, 43.37), new CGPoint(47.36, 48.29), new CGPoint(50.01, 45.99));
				nPath.AddCurveToPoint(new CGPoint(58.2, 34.89), new CGPoint(54.74, 40.75), new CGPoint(56.68, 37.92));
				nPath.AddCurveToPoint(new CGPoint(61.69, 25.53), new CGPoint(59.72, 31.86), new CGPoint(60.89, 28.74));
				nPath.AddCurveToPoint(new CGPoint(62.9, 15.97), new CGPoint(62.5, 22.32), new CGPoint(62.9, 19.14));
				nPath.AddLineTo(new CGPoint(62.9, 14.11));
				nPath.AddCurveToPoint(new CGPoint(70.03, 6.68), new CGPoint(65.7, 12.07), new CGPoint(68.07, 9.6));
				nPath.AddCurveToPoint(new CGPoint(61.78, 8.95), new CGPoint(67.37, 7.86), new CGPoint(64.62, 8.61));
				nPath.AddCurveToPoint(new CGPoint(68.08, 1.05), new CGPoint(64.87, 7.12), new CGPoint(66.97, 4.49));
				nPath.AddCurveToPoint(new CGPoint(59.02, 4.51), new CGPoint(65.17, 2.72), new CGPoint(62.15, 3.88));
				nPath.AddCurveToPoint(new CGPoint(48.49, 0), new CGPoint(56.07, 1.5), new CGPoint(52.56, 0));
				nPath.AddCurveToPoint(new CGPoint(38.34, 4.17), new CGPoint(44.51, 0), new CGPoint(41.13, 1.39));
				nPath.AddCurveToPoint(new CGPoint(34.14, 14.28), new CGPoint(35.54, 6.95), new CGPoint(34.14, 10.32));
				nPath.AddCurveToPoint(new CGPoint(34.45, 17.57), new CGPoint(34.14, 15.56), new CGPoint(34.25, 16.66));
				nPath.AddCurveToPoint(new CGPoint(17.92, 13.26), new CGPoint(28.54, 17.25), new CGPoint(23.04, 15.81));
				nPath.AddCurveToPoint(new CGPoint(4.87, 2.92), new CGPoint(12.81, 10.7), new CGPoint(8.46, 7.26));
				nPath.AddCurveToPoint(new CGPoint(2.93, 9.83), new CGPoint(3.58, 5.15), new CGPoint(2.93, 7.46));
				nPath.AddCurveToPoint(new CGPoint(4.65, 16.6), new CGPoint(2.93, 12.25), new CGPoint(3.5, 14.51));
				nPath.AddCurveToPoint(new CGPoint(9.34, 21.7), new CGPoint(5.8, 18.69), new CGPoint(7.36, 20.39));
				nPath.AddCurveToPoint(new CGPoint(2.86, 19.9), new CGPoint(7.04, 21.61), new CGPoint(4.88, 21.01));
				nPath.AddLineTo(new CGPoint(2.86, 20.07));
				nPath.AddCurveToPoint(new CGPoint(6.13, 29.2), new CGPoint(2.86, 23.53), new CGPoint(3.95, 26.57));
				nPath.AddCurveToPoint(new CGPoint(14.35, 34.11), new CGPoint(8.31, 31.82), new CGPoint(11.05, 33.46));
				nPath.AddCurveToPoint(new CGPoint(10.56, 34.59), new CGPoint(13.12, 34.43), new CGPoint(11.86, 34.59));
				nPath.AddCurveToPoint(new CGPoint(7.87, 34.35), new CGPoint(9.59, 34.59), new CGPoint(8.69, 34.51));
				nPath.AddCurveToPoint(new CGPoint(12.93, 41.44), new CGPoint(8.78, 37.22), new CGPoint(10.47, 39.58));
				nPath.AddCurveToPoint(new CGPoint(21.26, 44.29), new CGPoint(15.4, 43.29), new CGPoint(18.17, 44.24));
				nPath.AddCurveToPoint(new CGPoint(3.41, 51.03), new CGPoint(15.58, 48.78), new CGPoint(9.63, 51.03));
				nPath.AddCurveToPoint(new CGPoint(0, 50.8), new CGPoint(2.23, 51.03), new CGPoint(1.09, 50.95));
				nPath.AddCurveToPoint(new CGPoint(22.05, 56.63), new CGPoint(6.11, 54.68), new CGPoint(13.46, 56.63));
				nPath.AddLineTo(new CGPoint(22.05, 56.63));
				nPath.ClosePath();

				return nPath;
			}
		}
	}
}