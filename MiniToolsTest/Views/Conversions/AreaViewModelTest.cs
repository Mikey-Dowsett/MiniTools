using MiniTools.Views.Conversions;

namespace MiniToolsTest.Views.Conversions;

public class AreaViewModelTest {

    [Theory]
    //Square Millimeter
    [InlineData(0, 0, 500000000, 500000000, 1.0)] //Square Millimeter
    [InlineData(0, 1, 500000000, 5000000, 1.0)] //Square Centimeter
    [InlineData(0, 2, 500000000, 500, 1.0)] //Square Meter
    [InlineData(0, 3, 500000000, 0.0005, 1.0)] //Square Kilometer
    [InlineData(0, 4, 500000000, 0.05, 1.0)] //Hectare
    [InlineData(0, 5, 500000000, 775001.55, 1.0)] //Square Inch
    [InlineData(0, 6, 500000000, 5381.95521, 1.0)] //Square Foot
    [InlineData(0, 7, 500000000, 597.995023, 1.0)] //Square Yard
    [InlineData(0, 8, 500000000, 0.000193051079, 1.0)] //Square Mile
    [InlineData(0, 9, 500000000, 0.123552691, 1.0)] //Acre
    
    //Square Centimeter
    [InlineData(1, 0, 5000000, 500000000, 1.0)] //Square Millimeter
    [InlineData(1, 1, 5000000, 5000000, 1.0)] //Square Centimeter
    [InlineData(1, 2, 5000000, 500, 1.0)] //Square Meter
    [InlineData(1, 3, 5000000, 0.0005, 1.0)] //Square Kilometer
    [InlineData(1, 4, 5000000, 0.05, 1.0)] //Hectare
    [InlineData(1, 5, 5000000, 775001.55, 1.0)] //Square Inch
    [InlineData(1, 6, 5000000, 5381.95521, 1.0)] //Square Foot
    [InlineData(1, 7, 5000000, 597.995023, 1.0)] //Square Yard
    [InlineData(1, 8, 5000000, 0.000193051079, 1.0)] //Square Mile
    [InlineData(1, 9, 5000000, 0.123552691, 1.0)] //Acre
    
    //Square Meter
    [InlineData(2, 0, 500, 500000000, 1.0)] //Square Millimeter
    [InlineData(2, 1, 500, 5000000, 1.0)] //Square Centimeter
    [InlineData(2, 2, 500, 500, 1.0)] //Square Meter
    [InlineData(2, 3, 500, 0.0005, 1.0)] //Square Kilometer
    [InlineData(2, 4, 500, 0.05, 1.0)] //Hectare
    [InlineData(2, 5, 500, 775001.55, 1.0)] //Square Inch
    [InlineData(2, 6, 500, 5381.95521, 1.0)] //Square Foot
    [InlineData(2, 7, 500, 597.995023, 1.0)] //Square Yard
    [InlineData(2, 8, 500, 0.000193051079, 1.0)] //Square Mile
    [InlineData(2, 9, 500, 0.123552691, 1.0)] //Acre
    
    //Square Kilometer
    [InlineData(3, 0, 0.0005, 500000000, 1.0)] //Square Millimeter
    [InlineData(3, 1, 0.0005, 5000000, 1.0)] //Square Centimeter
    [InlineData(3, 2, 0.0005, 500, 1.0)] //Square Meter
    [InlineData(3, 3, 0.0005, 0.0005, 1.0)] //Square Kilometer
    [InlineData(3, 4, 0.0005, 0.05, 1.0)] //Hectare
    [InlineData(3, 5, 0.0005, 775001.55, 1.0)] //Square Inch
    [InlineData(3, 6, 0.0005, 5381.95521, 1.0)] //Square Foot
    [InlineData(3, 7, 0.0005, 597.995023, 1.0)] //Square Yard
    [InlineData(3, 8, 0.0005, 0.000193051079, 1.0)] //Square Mile
    [InlineData(3, 9, 0.0005, 0.123552691, 1.0)] //Acre
    
    //Square Hectare
    [InlineData(4, 0, 0.05, 500000000, 1.0)] //Square Millimeter
    [InlineData(4, 1, 0.05, 5000000, 1.0)] //Square Centimeter
    [InlineData(4, 2, 0.05, 500, 1.0)] //Square Meter
    [InlineData(4, 3, 0.05, 0.0005, 1.0)] //Square Kilometer
    [InlineData(4, 4, 0.05, 0.05, 1.0)] //Hectare
    [InlineData(4, 5, 0.05, 775001.55, 1.0)] //Square Inch
    [InlineData(4, 6, 0.05, 5381.95521, 1.0)] //Square Foot
    [InlineData(4, 7, 0.05, 597.995023, 1.0)] //Square Yard
    [InlineData(4, 8, 0.05, 0.000193051079, 1.0)] //Square Mile
    [InlineData(4, 9, 0.05, 0.123552691, 1.0)] //Acre
    
    //Square Inch
    [InlineData(5, 0, 775001.55, 500000000, 1.0)] //Square Millimeter
    [InlineData(5, 1, 775001.55, 5000000, 1.0)] //Square Centimeter
    [InlineData(5, 2, 775001.55, 500, 1.0)] //Square Meter
    [InlineData(5, 3, 775001.55, 0.0005, 1.0)] //Square Kilometer
    [InlineData(5, 4, 775001.55, 0.05, 1.0)] //Hectare
    [InlineData(5, 5, 775001.55, 775001.55, 1.0)] //Square Inch
    [InlineData(5, 6, 775001.55, 5381.95521, 1.0)] //Square Foot
    [InlineData(5, 7, 775001.55, 597.995023, 1.0)] //Square Yard
    [InlineData(5, 8, 775001.55, 0.000193051079, 1.0)] //Square Mile
    [InlineData(5, 9, 775001.55, 0.123552691, 1.0)] //Acre
    
    //Square Foot
    [InlineData(6, 0, 5381.95521, 500000484, 1.0)] //Square Millimeter
    [InlineData(6, 1, 5381.95521, 5000004, 1.0)] //Square Centimeter
    [InlineData(6, 2, 5381.95521, 500, 1.0)] //Square Meter
    [InlineData(6, 3, 5381.95521, 0.0005, 1.0)] //Square Kilometer
    [InlineData(6, 4, 5381.95521, 0.05, 1.0)] //Hectare
    [InlineData(6, 5, 5381.95521, 775001.55, 1.0)] //Square Inch
    [InlineData(6, 6, 5381.95521, 5381.95521, 1.0)] //Square Foot
    [InlineData(6, 7, 5381.95521, 597.995023, 1.0)] //Square Yard
    [InlineData(6, 8, 5381.95521, 0.000193051079, 1.0)] //Square Mile
    [InlineData(6, 9, 5381.95521, 0.123552691, 1.0)] //Acre
    
    //Square Yard
    [InlineData(7, 0, 597.995023, 500000483, 1.0)] //Square Millimeter
    [InlineData(7, 1, 597.995023, 5000004, 1.0)] //Square Centimeter
    [InlineData(7, 2, 597.995023, 500, 1.0)] //Square Meter
    [InlineData(7, 3, 597.995023, 0.0005, 1.0)] //Square Kilometer
    [InlineData(7, 4, 597.995023, 0.05, 1.0)] //Hectare
    [InlineData(7, 5, 597.995023, 775001.55, 1.0)] //Square Inch
    [InlineData(7, 6, 597.995023, 5381.95521, 1.0)] //Square Foot
    [InlineData(7, 7, 597.995023, 597.995023, 1.0)] //Square Yard
    [InlineData(7, 8, 597.995023, 0.000193051079, 1.0)] //Square Mile
    [InlineData(7, 9, 597.995023, 0.123552691, 1.0)] //Acre
    
    //Square Mile
    [InlineData(8, 0, 0.000193051079, 500000483, 1.0)] //Square Millimeter
    [InlineData(8, 1, 0.000193051079, 5000004, 1.0)] //Square Centimeter
    [InlineData(8, 2, 0.000193051079, 500, 1.0)] //Square Meter
    [InlineData(8, 3, 0.000193051079, 0.0005, 1.0)] //Square Kilometer
    [InlineData(8, 4, 0.000193051079, 0.05, 1.0)] //Hectare
    [InlineData(8, 5, 0.000193051079, 775001.55, 1.0)] //Square Inch
    [InlineData(8, 6, 0.000193051079, 5381.95521, 1.0)] //Square Foot
    [InlineData(8, 7, 0.000193051079, 597.995023, 1.0)] //Square Yard
    [InlineData(8, 8, 0.000193051079, 0.000193051079, 1.0)] //Square Mile
    [InlineData(8, 9, 0.000193051079, 0.123552691, 1.0)] //Acre
    
    //Acre
    [InlineData(9, 0, 0.123552691, 500000484, 1.0)] //Square Millimeter
    [InlineData(9, 1, 0.123552691, 5000004, 1.0)] //Square Centimeter
    [InlineData(9, 2, 0.123552691, 500, 1.0)] //Square Meter
    [InlineData(9, 3, 0.123552691, 0.0005, 1.0)] //Square Kilometer
    [InlineData(9, 4, 0.123552691, 0.05, 1.0)] //Hectare
    [InlineData(9, 5, 0.123552691, 775001.55, 1.0)] //Square Inch
    [InlineData(9, 6, 0.123552691, 5381.95521, 1.0)] //Square Foot
    [InlineData(9, 7, 0.123552691, 597.995023, 1.0)] //Square Yard
    [InlineData(9, 8, 0.123552691, 0.000193051079, 1.0)] //Square Mile
    [InlineData(9, 9, 0.123552691, 0.123552691, 1.0)] //Acre
    
    public void ConvertAreaTest(int firstFormat, int secondFormat, double firstArea, double expectedSecondArea, double tolerance) {
        AreaViewModel vm = new();
        vm.FirstFormat = firstFormat;
        vm.SecondFormat = secondFormat;
        vm.FirstArea = firstArea;
        vm.ConvertArea();
        Assert.Equal(expectedSecondArea, vm.SecondArea, tolerance);
    }
}