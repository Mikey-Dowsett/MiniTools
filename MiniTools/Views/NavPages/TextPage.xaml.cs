using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTools.Views.Text;

namespace MiniTools.Views.NavPages;

public partial class TextPage : ContentPage {
    public TextPage() {
        InitializeComponent();
    }

    private void OpenCases(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(TextCasesView));
    }
    
    private void OpenFindAndReplace(object? sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(FindAndReplaceView));
    }
}