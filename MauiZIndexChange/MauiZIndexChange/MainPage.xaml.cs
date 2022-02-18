namespace MauiZIndexChange;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		var button = sender as Button;
		var parentLayout = button.Parent as Layout;
		parentLayout.ZIndex = 0;
	}
}

