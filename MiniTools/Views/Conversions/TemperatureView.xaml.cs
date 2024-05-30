using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Conversions;

public partial class TemperatureView : ContentPage {
    public TemperatureView(TemperatureViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}