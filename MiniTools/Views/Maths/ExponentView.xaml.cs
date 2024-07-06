namespace MiniTools.Views.Maths;

public partial class ExponentView : ContentPage {
    private ExponentViewModel vm;
    
    public ExponentView(ExponentViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
}