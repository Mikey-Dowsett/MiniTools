using System.Data;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class SimpleCalculatorViewModel : ObservableObject {
    [ObservableProperty] private string equation = string.Empty;

    [RelayCommand]
    private void AddToEquation(char character) {
        if (Equation.Equals("Error")) {
            Equation = string.Empty;
        }
        
        Equation += character;
    }

    [RelayCommand]
    private void ClearInput() {
        Equation = string.Empty;
    }

    [RelayCommand]
    private void Delete() {
        if (Equation != string.Empty) {
            Equation = Equation.Remove(Equation.Length - 1);
        }
    }

    [RelayCommand]
    private void Evaluate() {
        try {
            DataTable dt = new DataTable();
            object answer = dt.Compute(Equation, "");
            answer = Math.Round(double.Parse(answer.ToString()), 4);
            Equation = answer.ToString();
        }
        catch (Exception ex) {
            Debug.WriteLine(ex.Message);
            Equation = "Error";
        }
    }
}