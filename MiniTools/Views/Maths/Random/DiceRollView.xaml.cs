namespace MiniTools.Views.Maths.Random;

public partial class DiceRollView : ContentPage {
    private System.Random rnd = new();
    
    public DiceRollView() {
        InitializeComponent();
    }

    private async void RollDice(object? sender, EventArgs e) {
        int dieNum = rnd.Next(6);

        Die.Source = "dice_roll.png";
        
        await Die.RotateTo(1080, 500);
        Die.Rotation = 0;

        Die.Source = dieNum switch {
            0 => "dice_one.png",
            1 => "dice_two.png",
            2 => "dice_three.png",
            3 => "dice_four.png",
            4 => "dice_five.png",
            5 => "dice_six.png",
            _ => "dice_one.png",
        };
    }
}