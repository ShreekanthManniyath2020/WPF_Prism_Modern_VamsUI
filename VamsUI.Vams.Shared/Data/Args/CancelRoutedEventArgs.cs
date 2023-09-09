using System.Windows;

namespace VamsUI.Vams.Data;

public class CancelRoutedEventArgs : RoutedEventArgs
{
    public CancelRoutedEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source)
    {
    }

    public bool Cancel { get; set; }
}
