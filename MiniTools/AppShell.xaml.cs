using MiniTools.Views.Conversions;
using MiniTools.Views.Maths;
using MiniTools.Views.Money;
using MiniTools.Views.Money.Interest;
using MiniTools.Views.NavPages;

namespace MiniTools;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
        
        //Navigation Pages
        Routing.RegisterRoute(nameof(ConversionsPage), typeof(ConversionsPage));
        Routing.RegisterRoute(nameof(MathsPage), typeof(MathsPage));
        Routing.RegisterRoute(nameof(MoneyPage), typeof(MoneyPage));
        
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
        
        //Money Views
        Routing.RegisterRoute(nameof(InterestView), typeof(InterestView));
        Routing.RegisterRoute(nameof(InterestBalanceView), typeof(InterestBalanceView));
    }
}