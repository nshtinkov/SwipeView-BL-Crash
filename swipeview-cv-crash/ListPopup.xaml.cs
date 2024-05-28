using CommunityToolkit.Maui.Views;

namespace swipeview_cv_crash;

public partial class ListPopup : Popup
{
	public List<string> Items { get; set; } = ["One"];

	public ListPopup()
	{
		InitializeComponent();

		BindingContext = this;
	}
}