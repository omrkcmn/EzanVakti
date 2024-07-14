using System.Collections.ObjectModel;
using EzanVakti;
using MauiIcons.Core;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MauiApp1;

public partial class PrayTimesPage : ContentPage
{

	public PrayTimesPage()
	{
		InitializeComponent();
		BindingContext = new GetPrayerTimesViewModel();

        _ = new MauiIcon();
        On<iOS>().SetUseSafeArea(true);
	}


     private void OnSettingsTapped(object sender, EventArgs e)
     {
            // Ayarlar ikonuna tıklandığında yapılacak işlemler
            Navigation.PushAsync(new SettingsPage());
     }
}