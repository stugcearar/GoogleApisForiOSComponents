using System;

using UIKit;
using CoreGraphics;

using Google.Maps;

namespace GoogleMapsAdvSample
{
	public class BasicMapViewController : UIViewController
	{
		public BasicMapViewController () : base ()
		{
			Title = "Basic Map";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var camera = CameraPosition.FromCamera (-33.868, 151.2086, 6);
			View = MapView.FromCamera (CGRect.Empty, camera);
		}
	}
}

