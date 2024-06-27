﻿using MiniTools.Views.Maths;

namespace MiniTools.Views.NavPages;

public partial class MathsPage : ContentPage {
    public MathsPage() {
        InitializeComponent();
    }

    private void OpenCalculator(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(SimpleCalculatorView));
    }
    
    private void OpenPercentage(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(PercentageView));
    }
    
    private void OpenAverage(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(AverageView));
    }
    
    private void OpenAspectRatio(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(AspectRatioView));
    }
}