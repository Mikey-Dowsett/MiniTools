namespace MiniTools.Views.Conversions;

public partial class ForceView : ContentPage {
    private ForceViewModel vm;
    
    public ForceView(ForceViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.FirstFormat = 4;
        vm.SecondFormat = 5;
        vm.FirstForce = 100;
        vm.SecondForce = 0.1;
    }
}