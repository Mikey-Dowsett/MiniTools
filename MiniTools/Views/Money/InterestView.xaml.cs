using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Money;

public partial class InterestView : ContentPage {
    private InterestViewModel vm;
    
    public InterestView(InterestViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing() {
        vm.ResetView();
    }
}