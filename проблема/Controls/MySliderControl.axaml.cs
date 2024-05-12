using Avalonia;
using Avalonia.Controls.Primitives;
using ReactiveUI;
using System.Diagnostics;
using System.Reactive;
using System.Windows.Input;


namespace MySlider;

public class MySliderControl : TemplatedControl
{
  // public static readonly StyledProperty<ICommand> ChangeStateCloseProperty =
  //           AvaloniaProperty.Register<MySliderControl, ICommand>("ChangeStateClose");

  // public ICommand ChangeStateClose
  // {
  //   get => GetValue(ChangeStateCloseProperty);
  //   set => SetValue(ChangeStateCloseProperty, value);
  // }
  public static readonly StyledProperty<bool> IsSliderClosedProperty =
        AvaloniaProperty.Register<MySliderControl, bool>("IsSliderClosed");

  public static readonly StyledProperty<int> MaxValProperty =
        AvaloniaProperty.Register<MySliderControl, int>("MaxVal");
  public static readonly StyledProperty<int> MinValProperty =
        AvaloniaProperty.Register<MySliderControl, int>("MinVal");
  public int Max_val { get => GetValue(MaxValProperty); set => SetValue(MaxValProperty,value); }
  public int Min_val { get => GetValue(MinValProperty); set => SetValue(MinValProperty, value); }
  public bool IsSliderСlosed {get => GetValue(IsSliderClosedProperty);
  set => SetValue(IsSliderClosedProperty,value);}

  public ReactiveCommand<Unit, Unit> ChangeStateCloseCommand { get; }
  private void ChangeStateClose()
  {
    if (IsSliderСlosed)
    {
      IsSliderСlosed = false;
      return;
    }
    IsSliderСlosed = true;
  }
  public MySliderControl(){
    ChangeStateCloseCommand = ReactiveCommand.Create(ChangeStateClose);
  }
}