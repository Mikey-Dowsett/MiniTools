using CommunityToolkit.Mvvm.ComponentModel;

namespace MiniTools.Views.Money.Interest;

public partial class InterestBalanceView : VerticalStackLayout {
    public List<string> InterestOptions = ["per year", "per month"];
    public List<string> TermOptions = ["years", "months"];
    
    public InterestBalanceView() {
        InitializeComponent();

        InterestDropDown.ItemsSource = InterestOptions;
        TermDropDown.ItemsSource = TermOptions;
        InterestDropDown.SelectedIndex = 0;
        TermDropDown.SelectedIndex = 0;
    }

    private void Calculate(object? sender, EventArgs e) {
        double interest;

        if (Principal.Text == "" || InterestRate.Text == "" || Term.Text == "") {
            return;
        }
        
        double principal = double.Parse(Principal.Text);
        double interestRate = double.Parse(InterestRate.Text) / 100;
        double term = double.Parse(Term.Text);

        if (InterestDropDown.SelectedIndex == 0) {
            if (TermDropDown.SelectedIndex == 0) {
                interest = principal * interestRate * term;
            }
            else {
                interest = principal * interestRate * term / 12;
            }
        }
        else {
            if (TermDropDown.SelectedIndex == 0) {
                interest = principal * interestRate * term * 12;
            }
            else {
                interest = principal * interestRate * term;
            }
        }

        TotalInterest.Text = $"{interest:C2}";
        EndBalance.Text = $"{(principal + interest):C2}";
    }
}