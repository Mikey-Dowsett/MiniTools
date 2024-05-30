using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Maths;

public partial class SimpleCalculatorView : ContentPage {
    public SimpleCalculatorView(SimpleCalculatorViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}