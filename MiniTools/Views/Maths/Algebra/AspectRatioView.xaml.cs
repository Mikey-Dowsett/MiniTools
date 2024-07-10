namespace MiniTools.Views.Maths;

public partial class AspectRatioView : ContentPage {
    private AspectRatioViewModel vm;
    
    public AspectRatioView(AspectRatioViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
}