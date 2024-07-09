namespace MiniTools.Views.Maths;

public partial class AverageView : ContentPage {
    private AverageViewModel vm;
    
    public AverageView(AverageViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
}