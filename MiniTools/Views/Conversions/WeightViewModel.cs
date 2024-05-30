using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Conversions;

public partial class WeightViewModel : ObservableObject {
    [ObservableProperty] private List<string> weightList =
        ["Microgram", "Milligram", "Gram", "Kilogram", "Metric Ton", "Ounce", "Pound", "Stone", "Ton"];

    [ObservableProperty] private int firstFormat = 2;
    [ObservableProperty] private int secondFormat = 3;
    [ObservableProperty] private double firstWeight = 10000;
    [ObservableProperty] private double secondWeight = 10;

    [RelayCommand]
    private void FlipFormats() {
        (FirstFormat, SecondFormat) = (SecondFormat, FirstFormat);
        ConvertWeight();
    }

    [RelayCommand]
    private void ConvertWeight() {
        SecondWeight = FirstFormat switch {
            0 => FromMicrogram(), //Microgram
            1 => FromMilligram(), //Milligram
            2 => FromGram(), //Gram
            3 => FromKilogram(), //Kilogram
            4 => FromMetricTon(), //Metric Ton
            5 => FromOunce(), //Ounce
            6 => FromPound(), //Pound
            7 => FromStone(), //Stone
            8 => FromTon(), //Ton
            _ => FirstWeight, //Default
        };
        
        SecondWeight = Math.Round(SecondWeight, 4);
    }
    
    private double FromMicrogram() {
        return SecondFormat switch {
            0 => FirstWeight, //Microgram
            1 => FirstWeight / 1000, //Milligram
            2 => FirstWeight / 1000000, //Gram
            3 => FirstWeight / 1000000000, //Kilogram
            4 => FirstWeight / 1000000000000, //Metric Ton
            5 => FirstWeight / 28350000, //Ounce
            6 => FirstWeight / 500000000, //Pound
            7 => FirstWeight / 6350000000, //Stone
            8 => FirstWeight / 907200000000, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromMilligram() {
        return SecondFormat switch {
            0 => FirstWeight * 1000, //Microgram
            1 => FirstWeight, //Milligram
            2 => FirstWeight / 1000, //Gram
            3 => FirstWeight / 1000000, //Kilogram
            4 => FirstWeight / 1000000000, //Metric Ton
            5 => FirstWeight / 28350, //Ounce
            6 => FirstWeight / 453600, //Pound
            7 => FirstWeight / 6350000, //Stone
            8 => FirstWeight / 907200000, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromGram() {
        return SecondFormat switch {
            0 => FirstWeight * 1000000, //Microgram
            1 => FirstWeight * 1000, //Milligram
            2 => FirstWeight, //Gram
            3 => FirstWeight / 1000, //Kilogram
            4 => FirstWeight / 1000000, //Metric Ton
            5 => FirstWeight / 28.35, //Ounce
            6 => FirstWeight / 453.6, //Pound
            7 => FirstWeight / 6350, //Stone
            8 => FirstWeight / 907200, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromKilogram() {
        return SecondFormat switch {
            0 => FirstWeight * 1000000000, //Microgram
            1 => FirstWeight * 1000000, //Milligram
            2 => FirstWeight * 1000, //Gram
            3 => FirstWeight, //Kilogram
            4 => FirstWeight / 1000, //Metric Ton
            5 => FirstWeight * 35.27, //Ounce
            6 => FirstWeight * 2.205, //Pound
            7 => FirstWeight / 6.35, //Stone
            8 => FirstWeight / 907.2, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromMetricTon() {
        return SecondFormat switch {
            0 => FirstWeight * 1000000000000, //Microgram
            1 => FirstWeight * 1000000000, //Milligram
            2 => FirstWeight * 1000000, //Gram
            3 => FirstWeight * 1000, //Kilogram
            4 => FirstWeight, //Metric Ton
            5 => FirstWeight * 35270, //Ounce
            6 => FirstWeight * 2205, //Pound
            7 => FirstWeight * 157.5, //Stone
            8 => FirstWeight * 1.102, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromOunce() {
        return SecondFormat switch {
            0 => FirstWeight * 28350000, //Microgram
            1 => FirstWeight * 28350, //Milligram
            2 => FirstWeight * 28.35, //Gram
            3 => FirstWeight / 35.27, //Kilogram
            4 => FirstWeight / 35270, //Metric Ton
            5 => FirstWeight, //Ounce
            6 => FirstWeight / 16, //Pound
            7 => FirstWeight / 224, //Stone
            8 => FirstWeight / 32000, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromPound() {
        return SecondFormat switch {
            0 => FirstWeight * 453600000, //Microgram
            1 => FirstWeight * 453600, //Milligram
            2 => FirstWeight * 453.6, //Gram
            3 => FirstWeight / 2.205, //Kilogram
            4 => FirstWeight / 2205, //Metric Ton
            5 => FirstWeight * 16, //Ounce
            6 => FirstWeight, //Pound
            7 => FirstWeight / 14, //Stone
            8 => FirstWeight / 2000, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromStone() {
        return SecondFormat switch {
            0 => FirstWeight * 6350000000, //Microgram
            1 => FirstWeight * 6350000, //Milligram
            2 => FirstWeight * 6350, //Gram
            3 => FirstWeight * 6.35, //Kilogram
            4 => FirstWeight / 157.5, //Metric Ton
            5 => FirstWeight * 224, //Ounce
            6 => FirstWeight * 14, //Pound
            7 => FirstWeight, //Stone
            8 => FirstWeight / 142.9, //Ton
            _ => FirstWeight, //Default
        };
    }
    
    private double FromTon() {
        return SecondFormat switch {
            0 => FirstWeight * 907200000000, //Microgram
            1 => FirstWeight * 907200000, //Milligram
            2 => FirstWeight * 907200, //Gram
            3 => FirstWeight * 907.2, //Kilogram
            4 => FirstWeight / 1.102, //Metric Ton
            5 => FirstWeight * 32000, //Ounce
            6 => FirstWeight * 2000, //Pound
            7 => FirstWeight * 142.9, //Stone
            8 => FirstWeight, //Ton
            _ => FirstWeight, //Default
        };
    }
}