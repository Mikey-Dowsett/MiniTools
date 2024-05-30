using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class ForceViewModel : ObservableObject {
    [ObservableProperty] private List<string> forceList = ["Dyne", "Kilogram-Force", "Kilopond", "Kip", "Newton", 
        "Kilonewton", "Ounce-Force", "Poundal", "Pound-Force", "Ton-Force"];
    [ObservableProperty] private int firstFormat = 4;
    [ObservableProperty] private int secondFormat = 5;
    [ObservableProperty] private double firstForce = 500;
    [ObservableProperty] private double secondForce = 0.5;
    
    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertForce();
    }
    
    [RelayCommand]
    public void ConvertForce() {
        SecondForce = FirstFormat switch {
            0 => FromDyne(), //Dyne
            1 => FromKilogramForce(), //Kilogram-Force
            2 => FromKilopond(), //Kilopond
            3 => FromKip(), //Kip
            4 => FromNewton(), //Newton
            5 => FromKilonewton(), //Kilonewton
            6 => FromOunceForce(), //Ounce-Force
            7 => FromPoundal(), //Poundal
            8 => FromPoundForce(), //Pound-Force
            9 => FromTonForce(), //Ton-Force
            _ => FirstForce
        };

        SecondForce = Math.Round(SecondForce, 4);
    }
    
    private double FromDyne() {
        return SecondFormat switch {
            0 => FirstForce, //Dyne
            1 => FirstForce / 980700, //Kilogram-Force
            2 => FirstForce / 980700, //Kilopond
            3 => FirstForce / 444800000, //Kip
            4 => FirstForce / 100000, //Newton
            5 => FirstForce / 100000000, //Kilonewton
            6 => FirstForce / 27800, //Ounce-Force
            7 => FirstForce / 13825.495, //Poundal
            8 => FirstForce / 444800, //Pound-Force
            9 => FirstForce / 889600000, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromKilogramForce() {
        return SecondFormat switch {
            0 => FirstForce * 980665, //Dyne
            1 => FirstForce, //Kilogram-Force
            2 => FirstForce, //Kilopond
            3 => FirstForce / 453.6, //Kip
            4 => FirstForce * 9.807, //Newton
            5 => FirstForce / 102, //Kilonewton
            6 => FirstForce * 35.27, //Ounce-Force
            7 => FirstForce * 70.932, //Poundal
            8 => FirstForce * 2.205, //Pound-Force
            9 => FirstForce / 907.2, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromKilopond() {
        return SecondFormat switch {
            0 => FirstForce * 980665, //Dyne
            1 => FirstForce, //Kilogram-Force
            2 => FirstForce, //Kilopond
            3 => FirstForce / 453.6, //Kip
            4 => FirstForce * 9.807, //Newton
            5 => FirstForce / 102, //Kilonewton
            6 => FirstForce * 35.27, //Ounce-Force
            7 => FirstForce * 70.932, //Poundal
            8 => FirstForce * 2.205, //Pound-Force
            9 => FirstForce / 907.2, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromKip() {
        return SecondFormat switch {
            0 => FirstForce * 444822160, //Dyne
            1 => FirstForce * 453.6, //Kilogram-Force
            2 => FirstForce * 453.6, //Kilopond
            3 => FirstForce, //Kip
            4 => FirstForce * 4448, //Newton
            5 => FirstForce * 4.448, //Kilonewton
            6 => FirstForce * 16000, //Ounce-Force
            7 => FirstForce * 32170, //Poundal
            8 => FirstForce * 1000, //Pound-Force
            9 => FirstForce / 2, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromNewton() {
        return SecondFormat switch {
            0 => FirstForce * 100000, //Dyne
            1 => FirstForce / 9.807, //Kilogram-Force
            2 => FirstForce / 9.807, //Kilopond
            3 => FirstForce / 4448, //Kip
            4 => FirstForce, //Newton
            5 => FirstForce / 1000, //Kilonewton
            6 => FirstForce * 3.597, //Ounce-Force
            7 => FirstForce * 7.233, //Poundal
            8 => FirstForce / 4.448, //Pound-Force
            9 => FirstForce / 8896, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromKilonewton() {
        return SecondFormat switch {
            0 => FirstForce * 100000000, //Dyne
            1 => FirstForce * 102, //Kilogram-Force
            2 => FirstForce * 102, //Kilopond
            3 => FirstForce / 4.448, //Kip
            4 => FirstForce * 1000, //Newton
            5 => FirstForce, //Kilonewton
            6 => FirstForce * 3597, //Ounce-Force
            7 => FirstForce * 7233, //Poundal
            8 => FirstForce * 224.8, //Pound-Force
            9 => FirstForce / 8.896, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromOunceForce() {
        return SecondFormat switch {
            0 => FirstForce * 27801.39, //Dyne
            1 => FirstForce / 35.27, //Kilogram-Force
            2 => FirstForce / 35.27, //Kilopond
            3 => FirstForce / 16000, //Kip
            4 => FirstForce / 3.597, //Newton
            5 => FirstForce / 3597, //Kilonewton
            6 => FirstForce, //Ounce-Force
            7 => FirstForce * 2.011, //Poundal
            8 => FirstForce / 16, //Pound-Force
            9 => FirstForce / 32000, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromPoundal() {
        return SecondFormat switch {
            0 => FirstForce * 13825.5, //Dyne
            1 => FirstForce / 70.93, //Kilogram-Force
            2 => FirstForce / 70.93, //Kilopond
            3 => FirstForce / 32170, //Kip
            4 => FirstForce / 7.233, //Newton
            5 => FirstForce / 7233, //Kilonewton
            6 => FirstForce / 2.011, //Ounce-Force
            7 => FirstForce, //Poundal
            8 => FirstForce / 32.17, //Pound-Force
            9 => FirstForce / 64350, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromPoundForce() {
        return SecondFormat switch {
            0 => FirstForce * 444822.2, //Dyne
            1 => FirstForce / 2.205, //Kilogram-Force
            2 => FirstForce / 2.205, //Kilopond
            3 => FirstForce / 1000, //Kip
            4 => FirstForce * 4.448, //Newton
            5 => FirstForce / 224.8, //Kilonewton
            6 => FirstForce * 16, //Ounce-Force
            7 => FirstForce * 32.17, //Poundal
            8 => FirstForce, //Pound-Force
            9 => FirstForce / 2000, //Ton-Force
            _ => FirstForce
        };
    }
    
    private double FromTonForce() {
        return SecondFormat switch {
            0 => FirstForce * 889644300, //Dyne
            1 => FirstForce * 907.2, //Kilogram-Force
            2 => FirstForce * 907.2, //Kilopond
            3 => FirstForce * 2, //Kip
            4 => FirstForce * 8896, //Newton
            5 => FirstForce * 8.896, //Kilonewton
            6 => FirstForce * 32000, //Ounce-Force
            7 => FirstForce * 64350, //Poundal
            8 => FirstForce * 2000, //Pound-Force
            9 => FirstForce, //Ton-Force
            _ => FirstForce
        };
    }
}