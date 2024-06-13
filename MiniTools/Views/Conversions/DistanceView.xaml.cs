namespace MiniTools.Views.Conversions;

public partial class DistanceView : ContentPage {
    private DistanceViewModel vm;
    
    public DistanceView(DistanceViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.FirstFormat = 2;
        vm.SecondFormat = 3;
        vm.FirstDistance = 100;
        vm.SecondDistance = 0.1;
    }
}