namespace MiniTools.Views.Conversions;

public partial class WeightView : ContentPage {
    private WeightViewModel vm;
    
    public WeightView(WeightViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing() {
        vm.FirstFormat = 2;
        vm.SecondFormat = 3;
        vm.FirstWeight = 10000;
        vm.SecondWeight = 10;
    }
}