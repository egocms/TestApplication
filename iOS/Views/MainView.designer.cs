// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestApplication.iOS
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		UIKit.UIButton LikeButton { get; set; }

		[Outlet]
		UIKit.UIImageView LikeImage { get; set; }

		[Outlet]
		UIKit.UILabel LikeLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LikeImage != null) {
				LikeImage.Dispose ();
				LikeImage = null;
			}

			if (LikeLabel != null) {
				LikeLabel.Dispose ();
				LikeLabel = null;
			}

			if (LikeButton != null) {
				LikeButton.Dispose ();
				LikeButton = null;
			}
		}
	}
}
