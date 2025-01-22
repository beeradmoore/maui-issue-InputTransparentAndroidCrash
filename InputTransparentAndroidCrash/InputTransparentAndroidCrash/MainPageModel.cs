using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace InputTransparentAndroidCrash;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    bool _pageIsEnabled = true;
    
    [ObservableProperty]
    bool _pageInputTransparent = false;

    [RelayCommand]
    void IsEnabledFalseTapped()
    {
        PageIsEnabled = false;
    }
    
    [RelayCommand]
    async Task IsEnabledFalseAsyncTapped()
    {
        PageIsEnabled = false;
    }
    
    
    [RelayCommand]
    void InputTransparentTrueTapped()
    {
        PageInputTransparent = true;
    }
    
    [RelayCommand]
    async Task InputTransparentTrueAsyncTapped()
    {
        PageInputTransparent = true;
    }
}