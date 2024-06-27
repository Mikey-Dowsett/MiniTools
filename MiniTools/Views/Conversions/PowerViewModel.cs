using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class PowerViewModel : ObservableObject {
    [ObservableProperty] private List<string> powerList =
        ["Watt", "Kilowatt", "Megawatt", "Gigawatt", "Horse Power"];
    [ObservableProperty] private int firstFormat = 0;
    [ObservableProperty] private int secondFormat = 1;
    [ObservableProperty] private double firstPower = 100;
    [ObservableProperty] private double secondPower = 0.1;
    
    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertPower();
    }


    [RelayCommand]
    public void ConvertPower() {
        SecondPower = FirstFormat switch {
            0 => FromWatt(), //Watt
            1 => FromKilowatt(), //Kilowatt
            2 => FromMegawatt(), //Megawatt
            3 => FromGigawatt(), //Gigawatt
            4 => FromHorsePower(), //Horse Power
            _ => FirstPower
        };

        SecondPower = Math.Round(SecondPower, 4);
    }

    private double FromWatt() {
        return SecondFormat switch {
            0 => FirstPower, //Watt
            1 => FirstPower * 1000, //Kilowatt
            2 => FirstPower * 1000000, //Megawatt
            3 => FirstPower * 1000000000, //Gigawatt
            4 => FirstPower * 745.69987158227, //Horse Power
            _ => FirstPower
        };
    }
    
    private double FromKilowatt() {
        return SecondFormat switch {
            0 => FirstPower / 1000, //Watt
            1 => FirstPower, //Kilowatt
            2 => FirstPower * 1000, //Megawatt
            3 => FirstPower * 1000000, //Gigawatt
            4 => FirstPower * 0.74569987158227, //Horse Power
            _ => FirstPower
        };
    }
    
    private double FromMegawatt() {
        return SecondFormat switch {
            0 => FirstPower / 1000000, //Watt
            1 => FirstPower / 1000, //Kilowatt
            2 => FirstPower, //Megawatt
            3 => FirstPower * 1000, //Gigawatt
            4 => FirstPower * 0.00074569987158227, //Horse Power
            _ => FirstPower
        };
    }
    
    private double FromGigawatt() {
        return SecondFormat switch {
            0 => FirstPower / 1000000000, //Watt
            1 => FirstPower / 1000000, //Kilowatt
            2 => FirstPower / 1000, //Megawatt
            3 => FirstPower, //Gigawatt
            4 => FirstPower * 0.00000074569987158227, //Horse Power
            _ => FirstPower
        };
    }
    
    private double FromHorsePower() {
        return SecondFormat switch {
            0 => FirstPower / 745.69987158227, //Watt
            1 => FirstPower / 0.74569987158227, //Kilowatt
            2 => FirstPower / 0.00074569987158227, //Megawatt
            3 => FirstPower / 0.00000074569987158227, //Gigawatt
            4 => FirstPower, //Horse Power
            _ => FirstPower
        };
    }
}