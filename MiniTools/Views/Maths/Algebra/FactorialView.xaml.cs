namespace MiniTools.Views.Maths;

public partial class FactorialView : ContentPage {
    private FactorialViewModel vm;
    
    public FactorialView(FactorialViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
}