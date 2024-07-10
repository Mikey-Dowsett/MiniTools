using MiniTools.Views.Maths;
using MiniTools.Views.Maths.Random;

namespace MiniTools.Views.NavPages;

public partial class MathsPage : ContentPage {
    public MathsPage() {
        InitializeComponent();
    }

    private void OpenCalculator(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(SimpleCalculatorView));
    }
    
    private void OpenPercentage(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(PercentageView));
    }
    
    private void OpenAverage(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(AverageView));
    }
    
    private void OpenAspectRatio(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(AspectRatioView));
    }
    
    private void OpenFractionSimplifier(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(FractionSimplifierView));
    }
    
    private void OpenFactorial(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(FactorialView));
    }
    
    private void OpenExponent(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(ExponentView));
    }    
    
    private void OpenCoinFlip(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(CoinFlipView));
    }
    
    private void OpenBottleSpin(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(BottleSpinView));
    }
    
    private void OpenDiceRoll(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(DiceRollView));
    }
}