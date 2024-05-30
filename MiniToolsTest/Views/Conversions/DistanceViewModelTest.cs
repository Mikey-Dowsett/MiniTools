using MiniTools.Views.Conversions;

namespace MiniToolsTest.Views.Conversions;

public class DistanceViewModelTest {
    [Theory]
    //Millimeter
    [InlineData(0, 0, 500000, 500000, 1.0)] //Millimeter
    [InlineData(0, 1, 500000, 50000, 1.0)] //Centimeter
    [InlineData(0, 2, 500000, 500, 1.0)] //Meter
    [InlineData(0, 3, 500000, 0.5, 1.0)] //Kilometer
    [InlineData(0, 4, 500000, 19685.0394, 1.0)] //Inch
    [InlineData(0, 5, 500000, 1640.41995, 1.0)] //Foot
    [InlineData(0, 6, 500000, 546.806649, 1.0)] //Yard
    [InlineData(0, 7, 500000, 0.310685596, 1.0)] //Mile
    
    //Centimeter
    [InlineData(1, 0, 50000, 500000, 1.0)] //Millimeter
    [InlineData(1, 1, 50000, 50000, 1.0)] //Centimeter
    [InlineData(1, 2, 50000, 500, 1.0)] //Meter
    [InlineData(1, 3, 50000, 0.5, 1.0)] //Kilometer
    [InlineData(1, 4, 50000, 19685.0394, 1.0)] //Inch
    [InlineData(1, 5, 50000, 1640.41995, 1.0)] //Foot
    [InlineData(1, 6, 50000, 546.806649, 1.0)] //Yard
    [InlineData(1, 7, 50000, 0.310685596, 1.0)] //Mile
    
    //Meter
    [InlineData(2, 0, 500, 500000, 1.0)] //Millimeter
    [InlineData(2, 1, 500, 50000, 1.0)] //Centimeter
    [InlineData(2, 2, 500, 500, 1.0)] //Meter
    [InlineData(2, 3, 500, 0.5, 1.0)] //Kilometer
    [InlineData(2, 4, 500, 19685.0394, 1.0)] //Inch
    [InlineData(2, 5, 500, 1640.41995, 1.0)] //Foot
    [InlineData(2, 6, 500, 546.806649, 1.0)] //Yard
    [InlineData(2, 7, 500, 0.310685596, 1.0)] //Mile
    
    //Kilometer
    [InlineData(3, 0, 0.5, 500000, 1.0)] //Millimeter
    [InlineData(3, 1, 0.5, 50000, 1.0)] //Centimeter
    [InlineData(3, 2, 0.5, 500, 1.0)] //Meter
    [InlineData(3, 3, 0.5, 0.5, 1.0)] //Kilometer
    [InlineData(3, 4, 0.5, 19685.0394, 1.0)] //Inch
    [InlineData(3, 5, 0.5, 1640.41995, 1.0)] //Foot
    [InlineData(3, 6, 0.5, 546.806649, 1.0)] //Yard
    [InlineData(3, 7, 0.5, 0.310685596, 1.0)] //Mile
    
    //Inch
    [InlineData(4, 0, 19685.0394, 500000, 1.0)] //Millimeter
    [InlineData(4, 1, 19685.0394, 50000, 1.0)] //Centimeter
    [InlineData(4, 2, 19685.0394, 500, 1.0)] //Meter
    [InlineData(4, 3, 19685.0394, 0.5, 1.0)] //Kilometer
    [InlineData(4, 4, 19685.0394, 19685.0394, 1.0)] //Inch
    [InlineData(4, 5, 19685.0394, 1640.41995, 1.0)] //Foot
    [InlineData(4, 6, 19685.0394, 546.806649, 1.0)] //Yard
    [InlineData(4, 7, 19685.0394, 0.310685596, 1.0)] //Mile
    
    //Foot
    [InlineData(5, 0, 1640.41995, 500000, 1.0)] //Millimeter
    [InlineData(5, 1, 1640.41995, 50000, 1.0)] //Centimeter
    [InlineData(5, 2, 1640.41995, 500, 1.0)] //Meter
    [InlineData(5, 3, 1640.41995, 0.5, 1.0)] //Kilometer
    [InlineData(5, 4, 1640.41995, 19685.0394, 1.0)] //Inch
    [InlineData(5, 5, 1640.41995, 1640.41995, 1.0)] //Foot
    [InlineData(5, 6, 1640.41995, 546.806649, 1.0)] //Yard
    [InlineData(5, 7, 1640.41995, 0.310685596, 1.0)] //Mile
    
    //Yard
    [InlineData(6, 0, 546.806649, 500000, 1.0)] //Millimeter
    [InlineData(6, 1, 546.806649, 50000, 1.0)] //Centimeter
    [InlineData(6, 2, 546.806649, 500, 1.0)] //Meter
    [InlineData(6, 3, 546.806649, 0.5, 1.0)] //Kilometer
    [InlineData(6, 4, 546.806649, 19685.0394, 1.0)] //Inch
    [InlineData(6, 5, 546.806649, 1640.41995, 1.0)] //Foot
    [InlineData(6, 6, 546.806649, 546.806649, 1.0)] //Yard
    [InlineData(6, 7, 546.806649, 0.310685596, 1.0)] //Mile
    
    //Mile
    [InlineData(7, 0, 0.310685596, 500000, 1.0)] //Millimeter
    [InlineData(7, 1, 0.310685596, 50000, 1.0)] //Centimeter
    [InlineData(7, 2, 0.310685596, 500, 1.0)] //Meter
    [InlineData(7, 3, 0.310685596, 0.5, 1.0)] //Kilometer
    [InlineData(7, 4, 0.310685596, 19685.0394, 1.0)] //Inch
    [InlineData(7, 5, 0.310685596, 1640.41995, 1.0)] //Foot
    [InlineData(7, 6, 0.310685596, 546.806649, 1.0)] //Yard
    [InlineData(7, 7, 0.310685596, 0.310685596, 1.0)] //Mile
    
    public void TestConvertDistance(int firstFormat, int secondFormat, double firstDistance, double expectedSecondDistance, double tolerance) {
        DistanceViewModel vm = new();
        vm.FirstFormat = firstFormat;
        vm.SecondFormat = secondFormat;
        vm.FirstDistance = firstDistance;
        vm.ConvertDistance();
        Assert.Equal(expectedSecondDistance, vm.SecondDistance, tolerance);
    }
}