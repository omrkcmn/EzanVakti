namespace MauiApp1;

public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void OnCountrySelected(object sender, EventArgs e)
        {
            var selectedCountry = countryPicker.SelectedItem as string;
            if (selectedCountry == "Türkiye")
            {
                cityPicker.ItemsSource = new List<string>
                {
                    "İstanbul", "Ankara", "İzmir"
                    // Diğer iller
                };
            }
            else if (selectedCountry == "Amerika")
            {
                cityPicker.ItemsSource = new List<string>
                {
                    "New York", "Los Angeles", "Chicago"
                    // Diğer şehirler
                };
            }
            // Diğer ülkeler için benzer şekilde
            cityPicker.IsEnabled = true;
            cityPicker.SelectedIndex = -1; // Temizle
            districtPicker.IsEnabled = false; // İlçe seçimi kapat
            districtPicker.SelectedIndex = -1; // Temizle
        }

        private void OnCitySelected(object sender, EventArgs e)
        {
            var selectedCity = cityPicker.SelectedItem as string;
            if (selectedCity == "İstanbul")
            {
                districtPicker.ItemsSource = new List<string>
                {
                    "Kadıköy", "Beşiktaş", "Üsküdar"
                    // Diğer ilçeler
                };
            }
            else if (selectedCity == "Ankara")
            {
                districtPicker.ItemsSource = new List<string>
                {
                    "Çankaya", "Keçiören", "Yenimahalle"
                    // Diğer ilçeler
                };
            }
            // Diğer iller için benzer şekilde
            districtPicker.IsEnabled = true;
            districtPicker.SelectedIndex = -1; // Temizle
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var selectedCountry = countryPicker.SelectedItem as string;
            var selectedCity = cityPicker.SelectedItem as string;
            var selectedDistrict = districtPicker.SelectedItem as string;

            // Kaydedilen değerlerle yapılacak işlemler
            DisplayAlert("Ayarlar", $"Seçimleriniz kaydedildi:\nÜlke: {selectedCountry}\nİl: {selectedCity}\nİlçe: {selectedDistrict}", "OK");
        }
    }