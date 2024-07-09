namespace MiniTools.Views.Maths.Random;

public partial class CoinFlipView : ContentPage {
    private const string HeadsImg = "coin_heads.png";
    private const string TailsImg = "coin_tails.png";
    private const string BlankImg = "coin_blank.png";
    
    System.Random rnd = new();
    
    private CoinFlipViewModel vm;
    
    public CoinFlipView(CoinFlipViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    private async void FlipCoin(object? sender, EventArgs e) {
        Coin.Source = BlankImg;
        
        Coin.ScaleTo(0.5, 50);
        await Coin.RotateYTo(720, 450);
        await Coin.ScaleTo(1, 50);
        
        Coin.RotationY = 0;
        Coin.Scale = 1;
        
        Coin.Source = rnd.Next(2) == 1 ? HeadsImg : TailsImg;
    }
}