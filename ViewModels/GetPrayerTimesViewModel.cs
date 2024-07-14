namespace EzanVakti;

public class GetPrayerTimesViewModel
{
    PrayTimeService _prayTimeService;
    public GetPrayerTimesViewModel()
    {
        _prayTimeService = new PrayTimeService();
        MainThread.BeginInvokeOnMainThread(async () => await GetPrayerTimes());
    }

    public async Task GetPrayerTimes(){
        var result = await _prayTimeService.GetPrayerTimes();
    }
}
