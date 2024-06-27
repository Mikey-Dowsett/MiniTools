namespace MiniTools.Views.Text;

public partial class TextCasesView : ContentPage {
    private TextCasesViewModel vm;
    
    public TextCasesView(TextCasesViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }
    
    protected override void OnAppearing() {
        vm.InputText = string.Empty;
        vm.SelectedCase = 0;
    }
}