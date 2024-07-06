namespace MiniTools.Views.Maths;

public partial class FractionSimplifierView : ContentPage {
    private FractionSimplifierViewModel vm;
    
    public FractionSimplifierView(FractionSimplifierViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
}