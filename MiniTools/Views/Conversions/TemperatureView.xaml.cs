namespace MiniTools.Views.Conversions;

public partial class TemperatureView : ContentPage {
    private TemperatureViewModel vm;
    
    public TemperatureView(TemperatureViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing() {
        vm.FirstFormat = 0;
        vm.SecondFormat = 1;
        vm.FirstTemp = 32;
        vm.SecondTemp = 0;
    }
}