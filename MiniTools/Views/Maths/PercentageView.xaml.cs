using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Maths;

public partial class PercentageView : ContentPage {
    public PercentageView(PercentageViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}