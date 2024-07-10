using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class ExponentViewModel : ObservableObject {
    [ObservableProperty] private double number;
    [ObservableProperty] private double exponent;
    [ObservableProperty] private double answer;

    [RelayCommand]
    private void CalculateExponent() {
        Answer = Math.Pow(Number, Exponent);
    }
}