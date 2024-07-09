namespace MiniTools.Views.Maths;

public partial class SimpleCalculatorView : ContentPage {
    private SimpleCalculatorViewModel vm;
    
    public SimpleCalculatorView(SimpleCalculatorViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.Equation = string.Empty;
    }
}