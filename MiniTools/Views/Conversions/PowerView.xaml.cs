namespace MiniTools.Views.Conversions;

public partial class PowerView : ContentPage {
    private PowerViewModel vm;
    
    public PowerView(PowerViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.FirstFormat = 0;
        vm.SecondFormat = 1;
        vm.FirstPower = 100;
        vm.SecondPower = 0.1;
    }
}