namespace MiniTools.Views.Maths;

public partial class PercentageView : ContentPage {
    private PercentageViewModel vm;
    
    public PercentageView(PercentageViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.Number = 50;
        vm.Percentage = 50;
        vm.Answer = 25;
    }
}