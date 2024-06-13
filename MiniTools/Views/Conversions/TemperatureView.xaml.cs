namespace MiniTools.Views.Conversions;

public partial class TemperatureView : ContentPage {
    public TemperatureView(TemperatureViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}