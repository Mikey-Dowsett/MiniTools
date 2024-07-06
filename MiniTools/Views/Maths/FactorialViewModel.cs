using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class FactorialViewModel : ObservableObject {
    [ObservableProperty] private int number;
    [ObservableProperty] private double factorial;

    [RelayCommand]
    private void FindFactorial() {
        double num = Number;
        Factorial = num--;
        
        while (num > 0) {
            Factorial = Factorial * num;
            num--;
        }
    }
}