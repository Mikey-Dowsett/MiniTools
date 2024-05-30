namespace MiniTools.Views.Maths;

public partial class MathsPage : ContentPage {
    public MathsPage() {
        InitializeComponent();
    }

    private void OpenCalculator(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(SimpleCalculatorView));
    }
}