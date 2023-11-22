using System.Windows.Input;
using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.Models;
using SimpleTrader.WPF.ViewModels;

namespace SimpleTrader.WPF.State.Navigators;

public class Navigator : ObservableObject, INavigator
{
    public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    
    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get
        {
            return _currentViewModel;
        }
        set
        {
            _currentViewModel = value;
            OnPropertyChanged();
        }
    }
    
}