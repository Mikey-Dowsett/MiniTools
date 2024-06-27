using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MiniTools.Views.Money;

public partial class InterestViewModel : ObservableObject {
    private readonly Color? darkColor;
    private readonly Color? lightColor;
    private readonly Color? accentColor;
    
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
        darkColor = (Color)appColorsDictionary["Dark"];
        lightColor = (Color)appColorsDictionary["Light"];
        accentColor = (Color)appColorsDictionary["Accent"];
        ShowBalance();
    }

    [RelayCommand]
    private void ShowBalance() {
        ResetButtons();
        BalanceButtonColor = accentColor;
        BalanceEnabled = true;
        Console.WriteLine(BalanceEnabled);
    }
    
    [RelayCommand]
    private void ShowPrincipal() {
        ResetButtons();
        PrincipleButtonColor = accentColor;
        PrincipalEnabled = true;
    }
    
    [RelayCommand]
    private void ShowTerm() {
        ResetButtons();
        TermButtonColor = accentColor;
        TermEnabled = true;
    }
    
    [RelayCommand]
    private void ShowRate() {
        ResetButtons();
        RateButtonColor = accentColor;
        RateEnabled = true;
    }

    private void ResetButtons() {
        if (Application.Current.UserAppTheme == AppTheme.Dark) {
            BalanceButtonColor = darkColor;
            PrincipleButtonColor = darkColor;
            TermButtonColor = darkColor;
            RateButtonColor = darkColor;
        }
        else {
            BalanceButtonColor = lightColor;
            PrincipleButtonColor = lightColor;
            TermButtonColor = lightColor;
            RateButtonColor = lightColor;
        }

        BalanceEnabled = false;
        PrincipalEnabled = false;
        TermEnabled = false;
        RateEnabled = false;
    }
}