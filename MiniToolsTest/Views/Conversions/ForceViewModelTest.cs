using MiniTools.Views.Conversions;

namespace MiniToolsTest.Views.Conversions;

public class ForceViewModelTest {

    [Theory]
    //Dyne
    [InlineData(0, 0, 50000000, 50000000, 1.0)] //Dyne
    [InlineData(0, 1, 50000000, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(0, 2, 50000000, 50.9858106, 1.0)] //Kilopond
    [InlineData(0, 3, 50000000, 0.112404462, 1.0)] //Kip
    [InlineData(0, 4, 50000000, 500, 1.0)] //Newton
    [InlineData(0, 5, 50000000, 0.5, 1.0)] //Kilonewton
    [InlineData(0, 6, 50000000, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(0, 7, 50000000, 3616.50573, 1.0)] //Poundal
    [InlineData(0, 8, 50000000, 112.404462, 1.0)] //Pound-Force
    [InlineData(0, 9, 50000000, 0.0562022372, 1.0)] //Ton-Force
    
    //Kilogram-Force
    [InlineData(1, 0, 50.9858106, 50000000, 1.0)] //Dyne
    [InlineData(1, 1, 50.9858106, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(1, 2, 50.9858106, 50.9858106, 1.0)] //Kilopond
    [InlineData(1, 3, 50.9858106, 0.112404462, 1.0)] //Kip
    [InlineData(1, 4, 50.9858106, 500, 1.0)] //Newton
    [InlineData(1, 5, 50.9858106, 0.5, 1.0)] //Kilonewton
    [InlineData(1, 6, 50.9858106, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(1, 7, 50.9858106, 3616.50573, 1.0)] //Poundal
    [InlineData(1, 8, 50.9858106, 112.404462, 1.0)] //Pound-Force
    [InlineData(1, 9, 50.9858106, 0.0562022372, 1.0)] //Ton-Force
    
    //Kilopond
    [InlineData(2, 0, 50.9858106, 50000000, 1.0)] //Dyne
    [InlineData(2, 1, 50.9858106, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(2, 2, 50.9858106, 50.9858106, 1.0)] //Kilopond
    [InlineData(2, 3, 50.9858106, 0.112404462, 1.0)] //Kip
    [InlineData(2, 4, 50.9858106, 500, 1.0)] //Newton
    [InlineData(2, 5, 50.9858106, 0.5, 1.0)] //Kilonewton
    [InlineData(2, 6, 50.9858106, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(2, 7, 50.9858106, 3616.50573, 1.0)] //Poundal
    [InlineData(2, 8, 50.9858106, 112.404462, 1.0)] //Pound-Force
    [InlineData(2, 9, 50.9858106, 0.0562022372, 1.0)] //Ton-Force
    
    //Kip
    [InlineData(3, 0, 0.112404462, 49999995.58047832, 1.0)] //Dyne
    [InlineData(3, 1, 0.112404462, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(3, 2, 0.112404462, 50.9858106, 1.0)] //Kilopond
    [InlineData(3, 3, 0.112404462, 0.112404462, 1.0)] //Kip
    [InlineData(3, 4, 0.112404462, 500, 1.0)] //Newton
    [InlineData(3, 5, 0.112404462, 0.5, 1.0)] //Kilonewton
    [InlineData(3, 6, 0.112404462, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(3, 7, 0.112404462, 3616.50573, 1.0)] //Poundal
    [InlineData(3, 8, 0.112404462, 112.404462, 1.0)] //Pound-Force
    [InlineData(3, 9, 0.112404462, 0.0562022372, 1.0)] //Ton-Force
    
    //Newton
    [InlineData(4, 0, 500, 50000000, 1.0)] //Dyne
    [InlineData(4, 1, 500, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(4, 2, 500, 50.9858106, 1.0)] //Kilopond
    [InlineData(4, 3, 500, 0.112404462, 1.0)] //Kip
    [InlineData(4, 4, 500, 500, 1.0)] //Newton
    [InlineData(4, 5, 500, 0.5, 1.0)] //Kilonewton
    [InlineData(4, 6, 500, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(4, 7, 500, 3616.50573, 1.0)] //Poundal
    [InlineData(4, 8, 500, 112.404462, 1.0)] //Pound-Force
    [InlineData(4, 9, 500, 0.0562022372, 1.0)] //Ton-Force
    
    //Kilonewton
    [InlineData(5, 0, 0.5, 50000000, 1.0)] //Dyne
    [InlineData(5, 1, 0.5, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(5, 2, 0.5, 50.9858106, 1.0)] //Kilopond
    [InlineData(5, 3, 0.5, 0.112404462, 1.0)] //Kip
    [InlineData(5, 4, 0.5, 500, 1.0)] //Newton
    [InlineData(5, 5, 0.5, 0.5, 1.0)] //Kilonewton
    [InlineData(5, 6, 0.5, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(5, 7, 0.5, 3616.50573, 1.0)] //Poundal
    [InlineData(5, 8, 0.5, 112.404462, 1.0)] //Pound-Force
    [InlineData(5, 9, 0.5, 0.0562022372, 1.0)] //Ton-Force
    
    //Ounce-Force
    [InlineData(6, 0, 1798.47123, 50000000, 1.0)] //Dyne
    [InlineData(6, 1, 1798.47123, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(6, 2, 1798.47123, 50.9858106, 1.0)] //Kilopond
    [InlineData(6, 3, 1798.47123, 0.112404462, 1.0)] //Kip
    [InlineData(6, 4, 1798.47123, 500, 1.0)] //Newton
    [InlineData(6, 5, 1798.47123, 0.5, 1.0)] //Kilonewton
    [InlineData(6, 6, 1798.47123, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(6, 7, 1798.47123, 3616.50573, 1.0)] //Poundal
    [InlineData(6, 8, 1798.47123, 112.404462, 1.0)] //Pound-Force
    [InlineData(6, 9, 1798.47123, 0.0562022372, 1.0)] //Ton-Force
    
    //Poundal
    [InlineData(7, 0, 3616.50573, 50000000, 1.0)] //Dyne
    [InlineData(7, 1, 3616.50573, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(7, 2, 3616.50573, 50.9858106, 1.0)] //Kilopond
    [InlineData(7, 3, 3616.50573, 0.112404462, 1.0)] //Kip
    [InlineData(7, 4, 3616.50573, 500, 1.0)] //Newton
    [InlineData(7, 5, 3616.50573, 0.5, 1.0)] //Kilonewton
    [InlineData(7, 6, 3616.50573, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(7, 7, 3616.50573, 3616.50573, 1.0)] //Poundal
    [InlineData(7, 8, 3616.50573, 112.404462, 1.0)] //Pound-Force
    [InlineData(7, 9, 3616.50573, 0.0562022372, 1.0)] //Ton-Force

    //Pound-Force
    [InlineData(8, 0, 112.404462, 50000000, 1.0)] //Dyne
    [InlineData(8, 1, 112.404462, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(8, 2, 112.404462, 50.9858106, 1.0)] //Kilopond
    [InlineData(8, 3, 112.404462, 0.112404462, 1.0)] //Kip
    [InlineData(8, 4, 112.404462, 500, 1.0)] //Newton
    [InlineData(8, 5, 112.404462, 0.5, 1.0)] //Kilonewton
    [InlineData(8, 6, 112.404462, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(8, 7, 112.404462, 3616.50573, 1.0)] //Poundal
    [InlineData(8, 8, 112.404462, 112.404462, 1.0)] //Pound-Force
    [InlineData(8, 9, 112.404462, 0.0562022372, 1.0)] //Ton-Force
    
    //Ton-Force
    [InlineData(9, 0, 0.0562022372, 50000000, 1.0)] //Dyne
    [InlineData(9, 1, 0.0562022372, 50.9858106, 1.0)] //Kilogram-Force
    [InlineData(9, 2, 0.0562022372, 50.9858106, 1.0)] //Kilopond
    [InlineData(9, 3, 0.0562022372, 0.112404462, 1.0)] //Kip
    [InlineData(9, 4, 0.0562022372, 500, 1.0)] //Newton
    [InlineData(9, 5, 0.0562022372, 0.5, 1.0)] //Kilonewton
    [InlineData(9, 6, 0.0562022372, 1798.47123, 1.0)] //Ounce-Force
    [InlineData(9, 7, 0.0562022372, 3616.50573, 1.0)] //Poundal
    [InlineData(9, 8, 0.0562022372, 112.404462, 1.0)] //Pound-Force
    [InlineData(9, 9, 0.0562022372, 0.0562022372, 1.0)] //Ton-Force
    
    public void TestConvertForce(int firstFormat, int secondFormat, double firstForce, double expectedSecondForce, double tolerance) {
        ForceViewModel vm = new();
        vm.FirstFormat = firstFormat;
        vm.SecondFormat = secondFormat;
        vm.FirstForce = firstForce;
        vm.ConvertForce();
        Assert.Equal(expectedSecondForce, vm.SecondForce, tolerance);
    }
}