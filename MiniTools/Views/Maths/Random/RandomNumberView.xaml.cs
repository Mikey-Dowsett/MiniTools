namespace MiniTools.Views.Maths.Random;

public partial class RandomNumberView : ContentPage {
    private System.Random rnd = new();
    
    public RandomNumberView() {
        InitializeComponent();
    }

    private void GenerateRandomNumber(object? sender, EventArgs e) {
        Number.Text = rnd.Next(int.Parse(Min.Text), int.Parse(Max.Text) + 1).ToString();
    }
}