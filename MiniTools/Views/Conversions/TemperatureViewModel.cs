using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class TemperatureViewModel : ObservableObject {
    [ObservableProperty] private List<string> temperatureList = ["Fahrenheit", "Celsius", "Kelvin", "Rankine"];
    [ObservableProperty] private int firstFormat = 0;
    [ObservableProperty] private int secondFormat = 1;
    [ObservableProperty] private double firstTemp = 32;
    [ObservableProperty] private double secondTemp = 0;
    
    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertTemperature();
    }

    [RelayCommand]
    public void ConvertTemperature() {
        SecondTemp = FirstFormat switch {
            0 => FromFahrenheit(), //Fahrenheit
            1 => FromCelsius(), //Celsius
            2 => FromKelvin(), //Kelvin
            3 => FromRankine(), //Rankine
            _ => SecondTemp
        };

        SecondTemp = Math.Round(SecondTemp, 4);
    }

    private double FromFahrenheit() {
        return SecondFormat switch {
            0 => FirstTemp, //Fahrenheit
            1 => (FirstTemp - 32) / 1.8, //Celsius
            2 => (FirstTemp + 459.67) / 1.8, //Kelvin
            3 => FirstTemp + 459.67, //Rankine
            _ => SecondTemp
        };
    }

    private double FromCelsius() {
        return SecondFormat switch {
            0 => FirstTemp * 1.8 + 32, //Fahrenheit
            1 => FirstTemp, //Celsius
            2 => FirstTemp + 273.15, //Kelvin
            3 => FirstTemp * 1.8 + 491.67, //Rankine
            _ => SecondTemp
        };
    }

    private double FromKelvin() {
        return SecondFormat switch {
            0 => FirstTemp * 1.8 - 459.67, //Fahrenheit
            1 => FirstTemp - 273.15, //Celsius
            2 => FirstTemp, //Kelvin
            3 => FirstTemp * 1.8, //Rankine
            _ => FirstTemp
        };
    }

    private double FromRankine() {
        return SecondFormat switch {
            0 => FirstTemp - 459.67, //Fahrenheit
            1 => FirstTemp / 1.8 - 273.15, //Celsius
            2 => FirstTemp / 1.8, //Kelvin
            3 => FirstTemp, //Rankine
            _ => FirstTemp
        };
    }
}