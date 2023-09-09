using System.Windows;

namespace VamsUI.Vams.Interactivity;

public interface IAttachedObject
{
    void Attach(DependencyObject dependencyObject);
    void Detach();

    DependencyObject AssociatedObject { get; }
}
