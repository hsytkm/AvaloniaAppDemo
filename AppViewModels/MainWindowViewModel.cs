using AppModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppViewModels;

public sealed partial class MainWindowViewModel : ObservableObject, IViewModel
{
    readonly ModelMaster _model = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Answer))]
    int _value1;

    [RelayCommand(CanExecute = nameof(CanCountUp1))]
    void CountUp1() => Value1++;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CountUp1Command))]
    bool _isEnableCountUp1 = true;
    bool CanCountUp1() => IsEnableCountUp1;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Answer))]
    double _sliderValue;

    public double Answer => _model.CalcValues(Value1, SliderValue);
}
