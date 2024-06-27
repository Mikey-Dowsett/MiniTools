using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class DistanceViewModel : ObservableObject {
    [ObservableProperty] private List<string> distanceList =
        ["Millimeter", "Centimeter", "Meter", "Kilometer", "Inch", "Foot", "Yard", "Mile"];

    [ObservableProperty] private int firstFormat = 2;
    [ObservableProperty] private int secondFormat = 3;
    [ObservableProperty] private double firstDistance = 100;
    [ObservableProperty] private double secondDistance = 0.1;
    
    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertDistance();
    }

    [RelayCommand]
    public void ConvertDistance() {
        SecondDistance = FirstFormat switch {
            0 => FromMillimeter(), //Millimeter
            1 => FromCentimeter(), //Centimeter
            2 => FromMeter(), //Meter
            3 => FromKilometer(), //Kilometer
            4 => FromInch(), //Inch
            5 => FromFoot(), //Foot
            6 => FromYard(), //Yard
            7 => FromMile(), //Mile
            _ => FirstFormat
        };

        SecondDistance = Math.Round(SecondDistance, 2);
    }

    private double FromMillimeter() {
        return SecondFormat switch {
            0 => FirstDistance, //Millimeter
            1 => FirstDistance / 10, //Centimeter
            2 => FirstDistance / 1000, //Meter
            3 => FirstDistance / 1000000, //Kilometer
            4 => FirstDistance / 25.4, //Inch
            5 => FirstDistance / 304.8, //Foot
            6 => FirstDistance / 914.4, //Yard
            7 => FirstDistance / 1609000, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromCentimeter() {
        return SecondFormat switch {
            0 => FirstDistance * 10, //Millimeter
            1 => FirstDistance, //Centimeter
            2 => FirstDistance / 100, //Meter
            3 => FirstDistance / 100000, //Kilometer
            4 => FirstDistance / 2.54, //Inch
            5 => FirstDistance / 30.48, //Foot
            6 => FirstDistance / 91.44, //Yard
            7 => FirstDistance / 160900, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromMeter() {
        return SecondFormat switch {
            0 => FirstDistance * 1000, //Millimeter
            1 => FirstDistance * 100, //Centimeter
            2 => FirstDistance, //Meter
            3 => FirstDistance / 1000, //Kilometer
            4 => FirstDistance * 39.37, //Inch
            5 => FirstDistance * 3.281, //Foot
            6 => FirstDistance * 1.094, //Yard
            7 => FirstDistance / 1609, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromKilometer() {
        return SecondFormat switch {
            0 => FirstDistance * 1000000, //Millimeter
            1 => FirstDistance * 100000, //Centimeter
            2 => FirstDistance * 1000, //Meter
            3 => FirstDistance, //Kilometer
            4 => FirstDistance * 39370, //Inch
            5 => FirstDistance * 3281, //Foot
            6 => FirstDistance * 1094, //Yard
            7 => FirstDistance / 1.609, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromInch() {
        return SecondFormat switch {
            0 => FirstDistance * 25.4, //Millimeter
            1 => FirstDistance * 2.54, //Centimeter
            2 => FirstDistance / 39.37, //Meter
            3 => FirstDistance / 39370.08, //Kilometer
            4 => FirstDistance, //Inch
            5 => FirstDistance / 12, //Foot
            6 => FirstDistance / 36, //Yard
            7 => FirstDistance / 63360, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromFoot() {
        return SecondFormat switch {
            0 => FirstDistance * 304.8, //Millimeter
            1 => FirstDistance * 30.48, //Centimeter
            2 => FirstDistance / 3.281, //Meter
            3 => FirstDistance / 3281, //Kilometer
            4 => FirstDistance * 12, //Inch
            5 => FirstDistance, //Foot
            6 => FirstDistance / 3, //Yard
            7 => FirstDistance / 5280, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromYard() {
        return SecondFormat switch {
            0 => FirstDistance * 914.4, //Millimeter
            1 => FirstDistance * 91.44, //Centimeter
            2 => FirstDistance / 1.094, //Meter
            3 => FirstDistance / 1094, //Kilometer
            4 => FirstDistance * 36, //Inch
            5 => FirstDistance * 3, //Foot
            6 => FirstDistance, //Yard
            7 => FirstDistance / 1760, //Mile
            _ => FirstDistance
        };
    }
    
    private double FromMile() {
        return SecondFormat switch {
            0 => FirstDistance * 1609344, //Millimeter
            1 => FirstDistance * 160934.4, //Centimeter
            2 => FirstDistance * 1609, //Meter
            3 => FirstDistance * 1.609, //Kilometer
            4 => FirstDistance * 63360, //Inch
            5 => FirstDistance * 5280, //Foot
            6 => FirstDistance * 1760, //Yard
            7 => FirstDistance, //Mile
            _ => FirstDistance
        };
    }
}