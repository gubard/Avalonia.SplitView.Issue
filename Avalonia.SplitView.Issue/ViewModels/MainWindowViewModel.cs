using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.SplitView.Issue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        OpenPaneCommand = new RelayCommand(() => IsPaneOpen = true);
        ClosePaneCommand = new RelayCommand(() => IsPaneOpen = false);
    }

    public ICommand OpenPaneCommand { get; }
    public ICommand ClosePaneCommand { get; }

    public bool IsPaneOpen
    {
        get;
        set => SetProperty(ref field, value);
    }
}
