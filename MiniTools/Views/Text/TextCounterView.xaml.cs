namespace MiniTools.Views.Text;

public partial class TextCounterView : ContentPage {
    private TextCounterViewModel vm;
    
    public TextCounterView(TextCounterViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing() {
        
    }
}