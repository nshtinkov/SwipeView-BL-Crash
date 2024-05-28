using CommunityToolkit.Maui.Views;

namespace swipeview_cv_crash
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var popup = new ListPopup();
			this.ShowPopup(popup);
		}
	}

}
