using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class PercentageViewModel : ObservableObject {
    [ObservableProperty] private double number;
    [ObservableProperty] private double percentage;
    [ObservableProperty] private double answer;

    [RelayCommand]
    private void FindPercent() {
        Answer = Math.Round(Number * (Percentage / 100), 2);
    }
}