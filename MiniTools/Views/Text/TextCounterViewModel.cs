using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Text;

public partial class TextCounterViewModel : ObservableObject {
    [ObservableProperty] private int characters;
    [ObservableProperty] private int words;
    [ObservableProperty] private int lines;
    [ObservableProperty] private int sentences;
    [ObservableProperty] private string? inputText;

    [RelayCommand]
    private void InputChange() {
        Characters = 0;
        Words = 0;
        Lines = 0;
        Sentences = 0;
        
        foreach (char c in InputText) {
            if (c == ' ') {
                Words++;
            }

            if (c == '\n') {
                Lines++;
            }

            if (c == '.') {
                Sentences++;
            }

            Characters++;
        }
    }
}