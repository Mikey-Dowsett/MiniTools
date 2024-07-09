using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using MiniTools.Views.Conversions;
using MiniTools.Views.Maths;
using MiniTools.Views.Maths.Random;
using MiniTools.Views.Money;
using MiniTools.Views.Money.Interest;
using MiniTools.Views.NavPages;
using MiniTools.Views.Text;
using UraniumUI;

namespace MiniTools;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .ConfigureFonts(fonts => {
                fonts.AddFont("Nunito-Regular.ttf", "Nunito");
                fonts.AddFontAwesomeIconFonts();
            });

        builder.Services.AddSingleton<ConversionsPage>();
        builder.Services.AddSingleton<MathsPage>();
        builder.Services.AddSingleton<MoneyPage>();
        builder.Services.AddSingleton<TextPage>();

        //Conversions
        builder.Services.AddSingleton<TemperatureView>();
        builder.Services.AddSingleton<TemperatureViewModel>();
        
        builder.Services.AddSingleton<DistanceView>();
        builder.Services.AddSingleton<DistanceViewModel>();
        
        builder.Services.AddSingleton<AreaView>();
        builder.Services.AddSingleton<AreaViewModel>();
        
        builder.Services.AddSingleton<ForceView>();
        builder.Services.AddSingleton<ForceViewModel>();
        
        builder.Services.AddSingleton<WeightView>();
        builder.Services.AddSingleton<WeightViewModel>();
        
        builder.Services.AddSingleton<PowerView>();
        builder.Services.AddSingleton<PowerViewModel>();
        
        //Maths
        builder.Services.AddSingleton<SimpleCalculatorView>();
        builder.Services.AddSingleton<SimpleCalculatorViewModel>();
        
        builder.Services.AddSingleton<PercentageView>();
        builder.Services.AddSingleton<PercentageViewModel>();
        
        builder.Services.AddSingleton<AverageView>();
        builder.Services.AddSingleton<AverageViewModel>();
        
        builder.Services.AddSingleton<AspectRatioView>();
        builder.Services.AddSingleton<AspectRatioViewModel>();
        
        builder.Services.AddSingleton<FractionSimplifierView>();
        builder.Services.AddSingleton<FractionSimplifierViewModel>();
        
        builder.Services.AddSingleton<FactorialView>();
        builder.Services.AddSingleton<FactorialViewModel>();
        
        builder.Services.AddSingleton<ExponentView>();
        builder.Services.AddSingleton<ExponentViewModel>();
        
        //Maths - Random
        builder.Services.AddSingleton<CoinFlipView>();
        builder.Services.AddSingleton<BottleSpinView>();
        
        //Money
        builder.Services.AddSingleton<InterestView>();
        builder.Services.AddSingleton<InterestViewModel>();
        builder.Services.AddSingleton<InterestBalanceView>();
        
        //Text
        builder.Services.AddSingleton<TextCasesView>();
        builder.Services.AddSingleton<TextCasesViewModel>();
        
        builder.Services.AddSingleton<FindAndReplaceView>();
        builder.Services.AddSingleton<FindAndReplaceViewModel>();
        
        builder.Services.AddSingleton<TextCounterView>();
        builder.Services.AddSingleton<TextCounterViewModel>();
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}