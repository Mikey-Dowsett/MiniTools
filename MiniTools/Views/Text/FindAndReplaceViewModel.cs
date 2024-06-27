using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Text;

public partial class FindAndReplaceViewModel : ObservableObject {
    [ObservableProperty] private string textToFind = string.Empty;
    [ObservableProperty] private string replacementText = string.Empty;
    [ObservableProperty] private string inputText = string.Empty;

    [RelayCommand]
    private void ReplaceText() {
        InputText = InputText.Replace(TextToFind, ReplacementText);
    }
}