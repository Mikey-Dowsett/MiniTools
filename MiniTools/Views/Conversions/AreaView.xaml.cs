namespace MiniTools.Views.Conversions;

public partial class AreaView : ContentPage {
    private AreaViewModel vm;
    
    public AreaView(AreaViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.FirstFormat = 2;
        vm.SecondFormat = 4;
        vm.FirstArea = 100;
        vm.SecondArea = 0.01;
    }
}