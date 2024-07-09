using MiniTools.Views.Conversions;
using MiniTools.Views.Maths;
using MiniTools.Views.Maths.Random;
using MiniTools.Views.Money;
using MiniTools.Views.Money.Interest;
using MiniTools.Views.NavPages;
using MiniTools.Views.Text;

namespace MiniTools;

public partial class AppShell : Shell {
    private bool isDarkMode = true;
    
    public AppShell() {
        InitializeComponent();
        
        //Navigation Pages
        Routing.RegisterRoute(nameof(ConversionsPage), typeof(ConversionsPage));
        Routing.RegisterRoute(nameof(MathsPage), typeof(MathsPage));
        Routing.RegisterRoute(nameof(MoneyPage), typeof(MoneyPage));
        Routing.RegisterRoute(nameof(TextPage), typeof(TextPage));
        
        //Conversion Views
        Routing.RegisterRoute(nameof(TemperatureView), typeof(TemperatureView));
        Routing.RegisterRoute(nameof(DistanceView), typeof(DistanceView));
        Routing.RegisterRoute(nameof(AreaView), typeof(AreaView));
        Routing.RegisterRoute(nameof(ForceView), typeof(ForceView));
        Routing.RegisterRoute(nameof(WeightView), typeof(WeightView));
        Routing.RegisterRoute(nameof(PowerView), typeof(PowerView));
        
        //Maths Views
        Routing.RegisterRoute(nameof(SimpleCalculatorView), typeof(SimpleCalculatorView));
        Routing.RegisterRoute(nameof(PercentageView), typeof(PercentageView));
        Routing.RegisterRoute(nameof(AverageView), typeof(AverageView));
        Routing.RegisterRoute(nameof(AspectRatioView), typeof(AspectRatioView));
        Routing.RegisterRoute(nameof(FractionSimplifierView), typeof(FractionSimplifierView));
        Routing.RegisterRoute(nameof(FactorialView), typeof(FactorialView));
        Routing.RegisterRoute(nameof(ExponentView), typeof(ExponentView));
        
        //Maths - Random Views
        Routing.RegisterRoute(nameof(CoinFlipView), typeof(CoinFlipView));
        
        //Money Views
        Routing.RegisterRoute(nameof(InterestView), typeof(InterestView));
        Routing.RegisterRoute(nameof(InterestBalanceView), typeof(InterestBalanceView));
        
        //Text
        Routing.RegisterRoute(nameof(TextCasesView), typeof(TextCasesView));
        Routing.RegisterRoute(nameof(FindAndReplaceView), typeof(FindAndReplaceView));
        Routing.RegisterRoute(nameof(TextCounterView), typeof(TextCounterView));
    }


    private void ChangeLightMode(object? sender, EventArgs e) {
        isDarkMode = !isDarkMode;

        if (isDarkMode) {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        
        LightButton.IsVisible = !isDarkMode;
        DarkButton.IsVisible = isDarkMode;
    }
}