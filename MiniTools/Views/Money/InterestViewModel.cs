using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Money;

public partial class InterestViewModel : ObservableObject {
    private readonly Color? smoke;
    private readonly Color? bronze;
    
    [ObservableProperty] private Color? balanceButtonColor;
    [ObservableProperty] private Color? principleButtonColor;
    [ObservableProperty] private Color? termButtonColor;
    [ObservableProperty] private Color? rateButtonColor;

    [ObservableProperty] private bool balanceEnabled;
    [ObservableProperty] private bool principalEnabled;
    [ObservableProperty] private bool termEnabled;
    [ObservableProperty] private bool rateEnabled;

    public InterestViewModel() {
        ResourceDictionary appColorsDictionary = Application.Current.Resources.MergedDictionaries
            .FirstOrDefault(d => d.Source.OriginalString.Contains("Colors.xaml"));
        smoke = (Color)appColorsDictionary["Charcoal"];
        bronze = (Color)appColorsDictionary["Bronze"];
        ShowBalance();
    }

    [RelayCommand]
    private void ShowBalance() {
        ResetButtons();
        BalanceButtonColor = bronze;
        BalanceEnabled = true;
        Console.WriteLine(BalanceEnabled);
    }
    
    [RelayCommand]
    private void ShowPrincipal() {
        ResetButtons();
        PrincipleButtonColor = bronze;
        PrincipalEnabled = true;
    }
    
    [RelayCommand]
    private void ShowTerm() {
        ResetButtons();
        TermButtonColor = bronze;
        TermEnabled = true;
    }
    
    [RelayCommand]
    private void ShowRate() {
        ResetButtons();
        RateButtonColor = bronze;
        RateEnabled = true;
    }

    private void ResetButtons() {
        BalanceButtonColor = smoke;
        PrincipleButtonColor = smoke;
        TermButtonColor = smoke;
        RateButtonColor = smoke;

        BalanceEnabled = false;
        PrincipalEnabled = false;
        TermEnabled = false;
        RateEnabled = false;
    }
}