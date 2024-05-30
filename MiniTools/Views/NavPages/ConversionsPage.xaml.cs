using MiniTools.Views.Conversions;

namespace MiniTools.Views.NavPages;

public partial class ConversionsPage : ContentPage {
    public ConversionsPage() {
        InitializeComponent();
    }

    private async void OpenTemperature(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(TemperatureView)}");
    }
    
    private async void OpenDistance(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(DistanceView)}");
    }
    
    private async void OpenArea(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(AreaView)}");
    }
    
    private async void OpenForce(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(ForceView)}");
    }
    
    private async void OpenWeight(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(WeightView)}");
    }
    
    private async void OpenPower(object? sender, EventArgs e) {
        await Shell.Current.GoToAsync($"{nameof(PowerView)}");
    }
}