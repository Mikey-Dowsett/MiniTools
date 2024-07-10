using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class FractionSimplifierViewModel : ObservableObject {
    [ObservableProperty] private double numerator;
    [ObservableProperty] private double denominator;
    [ObservableProperty] private double simplifiedNumerator;
    [ObservableProperty] private double simplifiedDenominator;
    [ObservableProperty] private int greatestCommonFactor;

    [RelayCommand]
    private void SimplifyFractions() {
        GreatestCommonFactor = FindGCF();

        SimplifiedNumerator = Numerator / GreatestCommonFactor;
        SimplifiedDenominator = Denominator / GreatestCommonFactor;
    }
    
    private int FindGCF() {
        List<int> widthFactors = new();
        List<int> heightFactors = new();
        
        for (int i = 0; i <= Numerator; i++) {
            if ((Numerator / i) % 1 == 0) {
                widthFactors.Insert(0, i);
            }
        }
        
        for (int i = 0; i <= Denominator; i++) {
            if ((Denominator / i) % 1 == 0) {
                heightFactors.Insert(0, i);
            }
        }

        foreach (int x in widthFactors) {
            foreach (int y in heightFactors) {
                if (x == y) {
                    return x;
                }
            }
        }

        return 1;
    }
}