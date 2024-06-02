using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Views.Money.Interest;

public partial class InterestPrincipalView : VerticalStackLayout {
    public List<string> InterestOptions = ["per year", "per month"];
    public List<string> TermOptions = ["years", "months"];
    
    public InterestPrincipalView() {
        InitializeComponent();
        
        InterestDropDown.ItemsSource = InterestOptions;
        TermDropDown.ItemsSource = TermOptions;
        InterestDropDown.SelectedIndex = 0;
        TermDropDown.SelectedIndex = 0;
    }
    
    private void Calculate(object? sender, EventArgs e) {
        double principal;

        if (EndBalance.Text == "" || InterestRate.Text == "" || Term.Text == "") {
            return;
        }
        
        double endBalance = double.Parse(EndBalance.Text);
        double interestRate = double.Parse(InterestRate.Text) / 100;
        double term = double.Parse(Term.Text);

        if (InterestDropDown.SelectedIndex == 0) {
            if (TermDropDown.SelectedIndex == 0) {
                principal = endBalance / (1 + interestRate * term);
            }
            else {
                principal = endBalance / (1 + interestRate * term / 12);
            }
        }
        else {
            if (TermDropDown.SelectedIndex == 0) {
                principal = endBalance / (1 + interestRate * term * 12);
            }
            else {
                principal = endBalance / (1 + interestRate * term);
            }
        }

        Principal.Text = $"{principal:C2}";
        TotalInterest.Text = $"{(endBalance - principal):C2}";
    }
}