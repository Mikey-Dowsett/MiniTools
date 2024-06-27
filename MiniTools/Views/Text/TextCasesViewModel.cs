using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Text;

public partial class TextCasesViewModel : ObservableObject {
    [ObservableProperty] private List<string> caseOptions = ["Upper Case", "Lower Case", "Title Case",
        "CamelCase", "Snake_Case", "Hyphen-Case", "Dot.Case", "AlTeRnAtInG cAsE", "sWitch cASE", "RaNDoM CaSE"];

    [ObservableProperty] private string? inputText = string.Empty;
    [ObservableProperty] private int selectedCase;

    [RelayCommand]
    private async void AddToClipboard() {
        await Clipboard.Default.SetTextAsync(InputText);
    }

    [RelayCommand]
    private void ChangeCase() {
        InputText = SelectedCase switch {
            0 => ToUpperCase(),
            1 => ToLowerCase(),
            2 => ToTitleCase(),
            3 => ToCamelCase(),
            4 => ToSnakeCase(),
            5 => ToHyphenCase(),
            6 => ToDotCase(),
            7 => ToAlternatingCase(),
            8 => ToSwitchCase(),
            9 => ToRandomCase(),
            10 => InputText,
            _ => InputText,
        };
    }

    private string ToUpperCase() {
        return InputText.ToUpper();
    }

    private string ToLowerCase() {
        return InputText.ToLower();
    }

    private string ToTitleCase() {
        string newText = "";
        string previousChar = "";
        foreach (char c in InputText) {
            if (previousChar is " " or "") {
                newText += c.ToString().ToUpper();
            }
            else {
                newText += c.ToString();
            }

            previousChar = c.ToString();
        }
        return newText;
    }

    private string ToCamelCase() {
        string newText = "";
        string previousChar = "";
        foreach (char c in InputText) {
            if (previousChar == " ") {
                newText += c.ToString().ToUpper();
            }
            else {
                newText += c.ToString();
            }

            previousChar = c.ToString();
        }

        return newText.Replace(' ', '\0');
    }

    private string ToSnakeCase() {
        return InputText.Replace(' ', '_');
    }
    
    private string ToHyphenCase() {
        return InputText.Replace(' ', '-');
    }
    
    private string ToDotCase() {
        return InputText.Replace(' ', '.');
    }
    
    private string ToAlternatingCase() {
        string newText = "";
        int counter = 0;
        
        foreach (char c in InputText) {
            if (counter % 2 == 0) {
                newText += c.ToString().ToUpper();
            }
            else {
                newText += c.ToString().ToLower();
            }

            counter++;
        }

        return newText;
    }

    private string ToSwitchCase() {
        string newText = "";
        
        foreach (char c in InputText) {
            if (Char.IsUpper(c)) {
                newText += c.ToString().ToLower();
            }
            else {
                newText += c.ToString().ToUpper();
            }
        }

        return newText;
    }

    private string ToRandomCase() {
        Random rnd = new Random();
        string newText = "";

        foreach (char c in InputText) {
            if (rnd.Next(1, 3) == 1) {
                newText += c.ToString().ToUpper();
            }
            else {
                newText += c.ToString().ToLower();
            }
        }

        return newText;
    }
}