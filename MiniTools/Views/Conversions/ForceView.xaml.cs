using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Conversions;

public partial class ForceView : ContentPage {
    public ForceView(ForceViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}