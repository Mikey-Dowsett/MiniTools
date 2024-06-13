using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Text;

public partial class TextCasesView : ContentPage {
    public TextCasesView(TextCasesViewModel vm) {
        InitializeComponent();

        this.BindingContext = vm;
    }
}