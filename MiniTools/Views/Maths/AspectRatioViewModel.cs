using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class AspectRatioViewModel : ObservableObject {
    [ObservableProperty] private double width;
    [ObservableProperty] private double height;
    [ObservableProperty] private string aspectRatio;
    [ObservableProperty] private int greatestCommonFactor;

    [RelayCommand]
    private void FindAspectRatio() {
        GreatestCommonFactor = FindGCF();
        double newWidth = Width / GreatestCommonFactor;
        double newHeight = Height / GreatestCommonFactor;
        AspectRatio = $"{newWidth}:{newHeight}";
    }
    
    private int FindGCF() {
        List<int> widthFactors = new();
        List<int> heightFactors = new();
        
        for (int i = 0; i < Width; i++) {
            if ((Width / i) % 1 == 0) {
                widthFactors.Insert(0, i);
            }
        }
        
        for (int i = 0; i < Height; i++) {
            if ((Height / i) % 1 == 0) {
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