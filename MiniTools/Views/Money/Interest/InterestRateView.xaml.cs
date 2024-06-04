using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Money.Interest;

public partial class InterestRateView : VerticalStackLayout {
    public List<string> TermOptions = ["years", "months"];
    
    public InterestRateView() {
        InitializeComponent();
        
        TermDropDown.ItemsSource = TermOptions;
        TermDropDown.SelectedIndex = 0;
    }
    
    private void Calculate(object? sender, EventArgs e) {
        double interestRate;

        if (EndBalance.Text == "" || Principal.Text == "" || Term.Text == "") {
            return;
        }
        
        double endBalance = double.Parse(EndBalance.Text);
        double principal = double.Parse(Principal.Text);
        double term = double.Parse(Term.Text);

        if (TermDropDown.SelectedIndex == 0) {
            interestRate = (endBalance / principal - 1) / term * 100;
        }
        else {
            interestRate = (endBalance / principal - 1) / (term / 12) * 100;
        }

        InterestRate.Text = $"{interestRate:N2}% per year";
    }
}