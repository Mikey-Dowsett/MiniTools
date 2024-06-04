using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Money.Interest;

public partial class InterestTermView : VerticalStackLayout {
    public List<string> InterestOptions = ["per year", "per month"];
    
    public InterestTermView() {
        InitializeComponent();
        
        InterestDropDown.ItemsSource = InterestOptions;
        InterestDropDown.SelectedIndex = 0;
    }
    
    private void Calculate(object? sender, EventArgs e) {
        double term;

        if (EndBalance.Text == "" || Principal.Text == "" || InterestRate.Text == "") {
            return;
        }
        
        double endBalance = double.Parse(EndBalance.Text);
        double principal = double.Parse(Principal.Text);
        double interestRate = double.Parse(InterestRate.Text) / 100;

        if (InterestDropDown.SelectedIndex == 0) {
            term = (endBalance / principal - 1) / interestRate;
        }
        else {
            term = (endBalance / principal - 1) / (interestRate * 12);
        }

        Term.Text = $"{term:N2} years";
    }
}