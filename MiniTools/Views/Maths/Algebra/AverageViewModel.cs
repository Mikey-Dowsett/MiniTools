using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Maths;

public partial class AverageViewModel : ObservableObject {
    [ObservableProperty] private string? numbers;
    [ObservableProperty] private double average;
    [ObservableProperty] private double median;
    [ObservableProperty] private double sum;
    [ObservableProperty] private double min;
    [ObservableProperty] private double max;

    [RelayCommand]
    private void FindAverage() {
        string[] numberListAsString = Numbers.Split(',');
        List<double> numberList = new List<double>();

        for (int i = 0; i < numberListAsString.Length; i++) {
            numberList.Add(double.Parse(numberListAsString[i]));
        }

        Average = numberList.Average();
        Median = FindMedian(numberList);
        Sum = numberList.Sum();
        Min = numberList.Min();
        Max = numberList.Max();
    }

    private double FindMedian(List<double> input) {
        double[] arr = input.ToArray();
        Array.Sort(arr);
        return arr[arr.Length / 2];
    }

}