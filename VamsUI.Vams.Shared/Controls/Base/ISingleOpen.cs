using System;

namespace VamsUI.Vams.Controls;

public interface ISingleOpen : IDisposable
{
    bool CanDispose { get; }
}
