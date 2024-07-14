using MauiApp1;

namespace EzanVakti;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new PrayTimesPage());
	}
}
