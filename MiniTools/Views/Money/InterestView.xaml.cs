namespace MiniTools.Views.Money;

public partial class InterestView : ContentPage {
    public InterestView(InterestViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
    }
}