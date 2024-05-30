using MiniTools.Views.Conversions;

namespace MiniToolsTest.Views.Conversions;

public class TemperatureViewModelTest {
    [Theory]
    //Fahrenheit
    [InlineData(0, 0, 32, 32, 1.0)] //Fahrenheit
    [InlineData(0, 1, 32, 0, 1.0)] //Celsius
    [InlineData(0, 2, 32, 273.15, 1.0)] //Kelvin
    [InlineData(0, 3, 32, 491.67, 1.0)] //Rankine
    
    //Celsius
    [InlineData(1, 0, 0, 32, 1.0)] //Fahrenheit
    [InlineData(1, 1, 0, 0, 1.0)] //Celsius
    [InlineData(1, 2, 0, 273.15, 1.0)] //Kelvin
    [InlineData(1, 3, 0, 491.67, 1.0)] //Rankine
    
    //Kelvin
    [InlineData(2, 0, 273.15, 32, 1.0)] //Fahrenheit
    [InlineData(2, 1, 273.15, 0, 1.0)] //Celsius
    [InlineData(2, 2, 273.15, 273.15, 1.0)] //Kelvin
    [InlineData(2, 3, 273.15, 491.67, 1.0)] //Rankine
    
    //Rankine
    [InlineData(3, 0, 491.67, 32, 1.0)] //Fahrenheit
    [InlineData(3, 1, 491.67, 0, 1.0)] //Celsius
    [InlineData(3, 2, 491.67, 273.15, 1.0)] //Kelvin
    [InlineData(3, 3, 491.67, 491.67, 1.0)] //Rankine
    public void TestConvertTemperature(int firstFormat, int secondFormat, double firstTemp, double expectedSecondTemp, double tolerance) {
        TemperatureViewModel vm = new();
        vm.FirstFormat = firstFormat;
        vm.SecondFormat = secondFormat;
        vm.FirstTemp = firstTemp;
        vm.ConvertTemperature();
        Assert.Equal(expectedSecondTemp, vm.SecondTemp, tolerance);
    }
}