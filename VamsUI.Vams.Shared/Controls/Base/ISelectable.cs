using System.Windows;

namespace VamsUI.Vams.Controls;

public interface ISelectable
{
    event RoutedEventHandler Selected;

    bool IsSelected { get; set; }
}
