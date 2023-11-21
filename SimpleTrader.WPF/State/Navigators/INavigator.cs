using System.Windows.Input;
using SimpleTrader.WPF.ViewModels;

namespace SimpleTrader.WPF.State.Navigators;

public interface INavigator
{
    ViewModelBase CurrentViewModel { get;}
    ICommand UpdateCurrnetViewModelCommand { get; }
}