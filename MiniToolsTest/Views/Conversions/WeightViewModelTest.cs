using MiniTools.Views.Conversions;

namespace MiniToolsTest.Views.Conversions;

public class WeightViewModelTest {
    [Theory]
    //Microgram
    [InlineData(0, 0, 10000000000, 10000000000, 1.0)] //Microgram
    [InlineData(0, 1, 10000000000, 10000000, 1.0)] //Milligram
    [InlineData(0, 2, 10000000000, 10000, 1.0)] //Gram
    [InlineData(0, 3, 10000000000, 10, 1.0)] //Kilogram
    [InlineData(0, 4, 10000000000, 0.01, 1.0)] //Metric Ton
    [InlineData(0, 5, 10000000000, 352.7396, 1.0)] //Ounce
    [InlineData(0, 6, 10000000000, 22.04623, 1.0)] //Pound
    [InlineData(0, 7, 10000000000, 1.57473, 1.0)] //Stone
    [InlineData(0, 8, 10000000000, 0.01102311, 1.0)] //Ton
    
    //Milligram
    [InlineData(1, 0, 10000000, 10000000000, 1.0)] //Microgram
    [InlineData(1, 1, 10000000, 10000000, 1.0)] //Milligram
    [InlineData(1, 2, 10000000, 10000, 1.0)] //Gram
    [InlineData(1, 3, 10000000, 10, 1.0)] //Kilogram
    [InlineData(1, 4, 10000000, 0.01, 1.0)] //Metric Ton
    [InlineData(1, 5, 10000000, 352.7396, 1.0)] //Ounce
    [InlineData(1, 6, 10000000, 22.04623, 1.0)] //Pound
    [InlineData(1, 7, 10000000, 1.57473, 1.0)] //Stone
    [InlineData(1, 8, 10000000, 0.01102311, 1.0)] //Ton
    
    //Gram
    [InlineData(2, 0, 10000, 10000000000, 1.0)] //Microgram
    [InlineData(2, 1, 10000, 10000000, 1.0)] //Milligram
    [InlineData(2, 2, 10000, 10000, 1.0)] //Gram
    [InlineData(2, 3, 10000, 10, 1.0)] //Kilogram
    [InlineData(2, 4, 10000, 0.01, 1.0)] //Metric Ton
    [InlineData(2, 5, 10000, 352.7396, 1.0)] //Ounce
    [InlineData(2, 6, 10000, 22.04623, 1.0)] //Pound
    [InlineData(2, 7, 10000, 1.57473, 1.0)] //Stone
    [InlineData(2, 8, 10000, 0.01102311, 1.0)] //Ton
    
    //Kilogram
    [InlineData(3, 0, 10, 10000000000, 1.0)] //Microgram
    [InlineData(3, 1, 10, 10000000, 1.0)] //Milligram
    [InlineData(3, 2, 10, 10000, 1.0)] //Gram
    [InlineData(3, 3, 10, 10, 1.0)] //Kilogram
    [InlineData(3, 4, 10, 0.01, 1.0)] //Metric Ton
    [InlineData(3, 5, 10, 352.7396, 1.0)] //Ounce
    [InlineData(3, 6, 10, 22.04623, 1.0)] //Pound
    [InlineData(3, 7, 10, 1.57473, 1.0)] //Stone
    [InlineData(3, 8, 10, 0.01102311, 1.0)] //Ton
    
    //Metric Ton
    [InlineData(4, 0, 0.01, 10000000000, 1.0)] //Microgram
    [InlineData(4, 1, 0.01, 10000000, 1.0)] //Milligram
    [InlineData(4, 2, 0.01, 10000, 1.0)] //Gram
    [InlineData(4, 3, 0.01, 10, 1.0)] //Kilogram
    [InlineData(4, 4, 0.01, 0.01, 1.0)] //Metric Ton
    [InlineData(4, 5, 0.01, 352.7396, 1.0)] //Ounce
    [InlineData(4, 6, 0.01, 22.04623, 1.0)] //Pound
    [InlineData(4, 7, 0.01, 1.57473, 1.0)] //Stone
    [InlineData(4, 8, 0.01, 0.01102311, 1.0)] //Ton
    
    //Ounce
    [InlineData(5, 0, 352.7396, 9999999447.30325, 1.0)] //Microgram
    [InlineData(5, 1, 352.7396, 10000000, 1.0)] //Milligram
    [InlineData(5, 2, 352.7396, 10000, 1.0)] //Gram
    [InlineData(5, 3, 352.7396, 10, 1.0)] //Kilogram
    [InlineData(5, 4, 352.7396, 0.01, 1.0)] //Metric Ton
    [InlineData(5, 5, 352.7396, 352.7396, 1.0)] //Ounce
    [InlineData(5, 6, 352.7396, 22.04623, 1.0)] //Pound
    [InlineData(5, 7, 352.7396, 1.57473, 1.0)] //Stone
    [InlineData(5, 8, 352.7396, 0.01102311, 1.0)] //Ton
    
    //Pound
    [InlineData(6, 0, 22.04623, 10000001715, 1.0)] //Microgram
    [InlineData(6, 1, 22.04623, 10000001, 1.0)] //Milligram
    [InlineData(6, 2, 22.04623, 10000, 1.0)] //Gram
    [InlineData(6, 3, 22.04623, 10, 1.0)] //Kilogram
    [InlineData(6, 4, 22.04623, 0.01, 1.0)] //Metric Ton
    [InlineData(6, 5, 22.04623, 352.7396, 1.0)] //Ounce
    [InlineData(6, 6, 22.04623, 22.04623, 1.0)] //Pound
    [InlineData(6, 7, 22.04623, 1.57473, 1.0)] //Stone
    [InlineData(6, 8, 22.04623, 0.01102311, 1.0)] //Ton
    
    //Stone
    [InlineData(7, 0, 1.57473, 9999997179, 1.0)] //Microgram
    [InlineData(7, 1, 1.57473, 9999997, 1.0)] //Milligram
    [InlineData(7, 2, 1.57473, 10000, 1.0)] //Gram
    [InlineData(7, 3, 1.57473, 10, 1.0)] //Kilogram
    [InlineData(7, 4, 1.57473, 0.01, 1.0)] //Metric Ton
    [InlineData(7, 5, 1.57473, 352.7396, 1.0)] //Ounce
    [InlineData(7, 6, 1.57473, 22.04623, 1.0)] //Pound
    [InlineData(7, 7, 1.57473, 1.57473, 1.0)] //Stone
    [InlineData(7, 8, 1.57473, 0.01102311, 1.0)] //Ton
    
    //Ton
    [InlineData(8, 0, 0.01102311, 9999997179, 1.0)] //Microgram
    [InlineData(8, 1, 0.01102311, 9999997, 1.0)] //Milligram
    [InlineData(8, 2, 0.01102311, 10000, 1.0)] //Gram
    [InlineData(8, 3, 0.01102311, 10, 1.0)] //Kilogram
    [InlineData(8, 4, 0.01102311, 0.01, 1.0)] //Metric Ton
    [InlineData(8, 5, 0.01102311, 352.7396, 1.0)] //Ounce
    [InlineData(8, 6, 0.01102311, 22.04623, 1.0)] //Pound
    [InlineData(8, 7, 0.01102311, 1.57473, 1.0)] //Stone
    [InlineData(8, 8, 0.01102311, 0.01102311, 1.0)] //Ton
    public void TestConvertWeight(int firstFormat, int secondFormat, double firstWeight, double expectedSecondWeight, double tolerance) {
        WeightViewModel vm = new();
        vm.FirstFormat = firstFormat;
        vm.SecondFormat = secondFormat;
        vm.FirstWeight = firstWeight;
        vm.ConvertWeight();
        Assert.Equal(expectedSecondWeight, vm.SecondWeight, tolerance);
    }
}