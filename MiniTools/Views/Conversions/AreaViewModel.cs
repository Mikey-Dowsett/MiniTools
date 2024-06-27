using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class AreaViewModel : ObservableObject {
    [ObservableProperty] private List<string> areaList = ["Square Millimeter", "Square Centimeter", "Square Meter", "Square Kilometer", "Hectare",
        "Square Inch", "Square Foot", "Square Yard", "Square Mile", "Acre"];
    [ObservableProperty] private int firstFormat = 2;
    [ObservableProperty] private int secondFormat = 4;
    [ObservableProperty] private double firstArea = 100;
    [ObservableProperty] private double secondArea = 0.01;
    
    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertArea();
    }

    [RelayCommand]
    public void ConvertArea() {
        SecondArea = FirstFormat switch {
            0 => FromMillimeter(), // Square Millimeter
            1 => FromCentimeter(), //Square Centimeter
            2 => FromMeter(), //Square Meter
            3 => FromKilometer(), //Square Kilometer
            4 => FromHectare(), //Hectare
            5 => FromInch(), //Square Inch
            6 => FromFoot(), //Square Foot
            7 => FromYard(), //Square Yard
            8 => FromMile(), //Square Mile
            9 => FromAcre(), //Acre
            _ => FirstArea
        };
        
        SecondArea = Math.Round(SecondArea, 4);
    }

    private double FromMillimeter() {
        return SecondFormat switch {
            0 => FirstArea, // Square Millimeter
            1 => FirstArea / 100, //Square Centimeter
            2 => FirstArea / 1000000, //Square Meter
            3 => FirstArea / 1000000000000, //Square Kilometer
            4 => FirstArea / 10000000000, //Hectare
            5 => FirstArea / 645.160624, //Square Inch
            6 => FirstArea / 92900, //Square Foot
            7 => FirstArea / 836100, //Square Yard
            8 => FirstArea / 2590000000000, //Square Mile
            9 => FirstArea / 4047000000, //Acre
            _ => FirstArea
        };
    }
    
    private double FromCentimeter() {
        return SecondFormat switch {
            0 => FirstArea * 100, // Square Millimeter
            1 => FirstArea, //Square Centimeter
            2 => FirstArea / 10000, //Square Meter
            3 => FirstArea / 10000000000, //Square Kilometer
            4 => FirstArea / 10000000000, //Hectare
            5 => FirstArea / 6.45160624, //Square Inch
            6 => FirstArea / 929, //Square Foot
            7 => FirstArea / 8361, //Square Yard
            8 => FirstArea / 25900000000, //Square Mile
            9 => FirstArea / 40470000, //Acre
            _ => FirstArea
        };
    }
    
    private double FromMeter() {
        return SecondFormat switch {
            0 => FirstArea * 1000000, // Square Millimeter
            1 => FirstArea * 10000, //Square Centimeter
            2 => FirstArea, //Square Meter
            3 => FirstArea / 1000000, //Square Kilometer
            4 => FirstArea / 10000, //Hectare
            5 => FirstArea * 1550.0016, //Square Inch
            6 => FirstArea * 10.7639, //Square Foot
            7 => FirstArea * 1.196, //Square Yard
            8 => FirstArea / 2590000, //Square Mile
            9 => FirstArea / 4047, //Acre
            _ => FirstArea
        };
    }
    
    private double FromKilometer() {
        return SecondFormat switch {
            0 => FirstArea * 1000000000000, // Square Millimeter
            1 => FirstArea * 10000000000, //Square Centimeter
            2 => FirstArea * 1000000, //Square Meter
            3 => FirstArea, //Square Kilometer
            4 => FirstArea * 100, //Hectare
            5 => FirstArea * 1550001600, //Square Inch
            6 => FirstArea * 10763900, //Square Foot
            7 => FirstArea * 1196000, //Square Yard
            8 => FirstArea / 2.59, //Square Mile
            9 => FirstArea * 247.1, //Acre
            _ => FirstArea
        };
    }
    
    private double FromHectare() {
        return SecondFormat switch {
            0 => FirstArea * 10000000000, // Square Millimeter
            1 => FirstArea * 100000000, //Square Centimeter
            2 => FirstArea * 10000, //Square Meter
            3 => FirstArea / 100, //Square Kilometer
            4 => FirstArea, //Hectare
            5 => FirstArea * 15500016, //Square Inch
            6 => FirstArea * 107639, //Square Foot
            7 => FirstArea * 11960, //Square Yard
            8 => FirstArea / 259, //Square Mile
            9 => FirstArea * 2.471, //Acre
            _ => FirstArea
        };
    }
    
    private double FromInch() {
        return SecondFormat switch {
            0 => FirstArea * 645.16, // Square Millimeter
            1 => FirstArea * 6.4516, //Square Centimeter
            2 => FirstArea / 1550, //Square Meter
            3 => FirstArea / 1550000000, //Square Kilometer
            4 => FirstArea / 15500000, //Hectare
            5 => FirstArea, //Square Inch
            6 => FirstArea / 144, //Square Foot
            7 => FirstArea / 1296, //Square Yard
            8 => FirstArea / 4014000000, //Square Mile
            9 => FirstArea / 6273000, //Acre
            _ => FirstArea
        };
    }
    
    private double FromFoot() {
        return SecondFormat switch {
            0 => FirstArea * 92903.12990644656 , // Square Millimeter
            1 => FirstArea * 929.0312990644655 , //Square Centimeter
            2 => FirstArea / 10.76, //Square Meter
            3 => FirstArea / 10760000, //Square Kilometer
            4 => FirstArea / 107600, //Hectare
            5 => FirstArea * 144, //Square Inch
            6 => FirstArea, //Square Foot
            7 => FirstArea / 9, //Square Yard
            8 => FirstArea / 27880000, //Square Mile
            9 => FirstArea / 43560, //Acre
            _ => FirstArea
        };
    }
    
    private double FromYard() {
        return SecondFormat switch {
            0 => FirstArea * 836128.169158019, // Square Millimeter
            1 => FirstArea * 8361.28169158019, //Square Centimeter
            2 => FirstArea / 1.196, //Square Meter
            3 => FirstArea / 1196000, //Square Kilometer
            4 => FirstArea / 11960, //Hectare
            5 => FirstArea * 1296, //Square Inch
            6 => FirstArea * 9, //Square Foot
            7 => FirstArea, //Square Yard
            8 => FirstArea / 3098000, //Square Mile
            9 => FirstArea / 4840, //Acre
            _ => FirstArea
        };
    }
    
    private double FromMile() {
        return SecondFormat switch {
            0 => FirstArea * 2589990616783.88, // Square Millimeter
            1 => FirstArea * 25899906167.838795, //Square Centimeter
            2 => FirstArea * 2589990.6167838797, //Square Meter
            3 => FirstArea * 2.5899906167838798, //Square Kilometer
            4 => FirstArea * 258.999061678388, //Hectare
            5 => FirstArea * 4014489600, //Square Inch
            6 => FirstArea * 27880000, //Square Foot
            7 => FirstArea * 3098000, //Square Yard
            8 => FirstArea, //Square Mile
            9 => FirstArea * 640, //Acre
            _ => FirstArea
        };
    }
    
    private double FromAcre() {
        return SecondFormat switch {
            0 => FirstArea * 4046860338.7248125, // Square Millimeter
            1 => FirstArea * 40468603.38724812, //Square Centimeter
            2 => FirstArea * 4047, //Square Meter
            3 => FirstArea / 247.1, //Square Kilometer
            4 => FirstArea / 2.471, //Hectare
            5 => FirstArea * 6272640, //Square Inch
            6 => FirstArea * 43560, //Square Foot
            7 => FirstArea * 4840, //Square Yard
            8 => FirstArea / 640, //Square Mile
            9 => FirstArea, //Acre
            _ => FirstArea
        };
    }
}