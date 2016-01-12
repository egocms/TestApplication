using Cirrious.MvvmCross.ViewModels;

namespace TestApplication.ViewModels
{
	public class MainViewModel 
		: MvxViewModel
	{
		int _likeCounter;

		public int LikeCounter {
			get {
				return _likeCounter;
			}
			set {
				_likeCounter = value;
				RaisePropertyChanged (() => LikeCounter);
			}
		}

		public IMvxCommand LikeCommand {
			get {
				return new MvxCommand (() => {
					LikeCounter++;
				});
			}
		}
	}
}
