using System.Windows.Input;
using SimpleTrader.WPF.ViewModels;

namespace SimpleTrader.WPF.State.Navigators;

public class Navigator : INavigator
{
    public ViewModelBase CurrentViewModel { get; }
    public ICommand UpdateCurrnetViewModelCommand { get; }
    
    
    
}