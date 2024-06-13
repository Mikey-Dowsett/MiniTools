namespace MiniTools.Views.Text;

public partial class FindAndReplaceView : ContentPage {
    private FindAndReplaceViewModel vm;
    public FindAndReplaceView(FindAndReplaceViewModel vm) {
        InitializeComponent();

        BindingContext = vm;
        this.vm = vm;
    }

    protected override void OnAppearing() {
        vm.TextToFind = string.Empty;
        vm.ReplacementText = string.Empty;
        vm.InputText = string.Empty;
    }
}