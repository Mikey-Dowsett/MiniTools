using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths.Random;

public partial class CoinFlipViewModel : ObservableObject {
    System.Random rnd = new();
    
    [ObservableProperty] private ImageSource coinImage = "coin_heads.png";

    [RelayCommand]
    private void FlipCoin() {
        CoinImage = rnd.Next(2) == 1 ? "coin_heads.png" : "coin_tails.png";
    }
}