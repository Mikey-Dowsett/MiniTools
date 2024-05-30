using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using MiniTools.Views.Conversions;
using MiniTools.Views.Maths;
using MiniTools.Views.NavPages;
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
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFontAwesomeIconFonts();
            });

        builder.Services.AddSingleton<ConversionsPage>();
        builder.Services.AddSingleton<MathsPage>();

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
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}