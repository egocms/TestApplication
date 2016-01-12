using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TestApplication.ViewModels;

namespace TestApplication.iOS
{
	public partial class MainView : MvxViewController
	{
		public MainView () : base ("MainView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			LikeImage.Image = UIImage.FromBundle ("starwars.jpg");

			var set = this.CreateBindingSet<MainView, MainViewModel> ();
			set.Bind (LikeButton).To (vm => vm.LikeCommand);
			set.Bind (LikeLabel).To (vm => vm.LikeCounter).WithConversion (new LikeValueConverter (), null);
			set.Apply ();
		}
	}
}


