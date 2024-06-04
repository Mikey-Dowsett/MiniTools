using MiniTools.Views.Money;

namespace MiniTools.Views.NavPages;

public partial class MoneyPage : ContentPage {
    public MoneyPage() {
        InitializeComponent();
    }


    private void OpenInterest(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(InterestView));
    }
}