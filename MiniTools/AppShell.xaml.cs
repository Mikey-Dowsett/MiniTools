using MiniTools.Views.Conversions;
using MiniTools.Views.Maths;

namespace MiniTools;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
        
        //Navigation Pages
        Routing.RegisterRoute(nameof(ConversionsPage), typeof(ConversionsPage));
        Routing.RegisterRoute(nameof(MathsPage), typeof(MathsPage));
        
        //Conversion Views
        Routing.RegisterRoute(nameof(TemperatureView), typeof(TemperatureView));
        Routing.RegisterRoute(nameof(DistanceView), typeof(DistanceView));
        Routing.RegisterRoute(nameof(AreaView), typeof(AreaView));
        Routing.RegisterRoute(nameof(ForceView), typeof(ForceView));
        Routing.RegisterRoute(nameof(WeightView), typeof(WeightView));
        
        //Maths Views
        Routing.RegisterRoute(nameof(SimpleCalculatorView), typeof(SimpleCalculatorView));
    }
}