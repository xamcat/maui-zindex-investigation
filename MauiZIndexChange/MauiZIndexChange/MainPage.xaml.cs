
namespace MauiZIndexChange;

public partial class MainPage : ContentPage
{
    private List<VerticalStackLayout> _stackLayouts;

    public MainPage()
    {
        InitializeComponent();
        _stackLayouts = new List<VerticalStackLayout>
        {
            Layout00,
            Layout01,
            Layout10,
            Layout11
        };
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var parentLayout = button.Parent as VerticalStackLayout;

        foreach (var layout in _stackLayouts)
        {
            if (layout == parentLayout)
            {
                layout.ZIndex = 0;
            }
            else
            {
                layout.ZIndex = 1;
            }
        }
    }
}
