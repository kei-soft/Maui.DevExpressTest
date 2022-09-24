namespace Maui.DevExpressTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new List<string>() { "Milk", "Tea", "Coffee" };
	}
}

