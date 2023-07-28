namespace Biscoito;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBtnComerClicked(object sender, EventArgs e)
	{
		imgCookie.Source = "cookiemordido.png";
		((Button)sender).IsEnabled = false;
	}
}

