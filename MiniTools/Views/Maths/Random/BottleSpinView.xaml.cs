namespace MiniTools.Views.Maths.Random;

public partial class BottleSpinView : ContentPage {
    System.Random rnd = new();
    
    public BottleSpinView() {
        InitializeComponent();
    }
    
    private async void SpinBottle(object? sender, EventArgs e) {
        Bottle.Rotation = 0;
        await Bottle.RotateTo(2160, 1000);
        await Bottle.RotateTo(3240, 1000);
        int direction = rnd.Next(361);
        await Bottle.RotateTo(3240 + direction, (uint)direction);
    }
}