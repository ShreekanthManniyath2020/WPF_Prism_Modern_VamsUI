using System;

namespace VamsUI.Vams.Interactivity;

public class PreviewInvokeEventArgs : EventArgs
{
    public bool Cancelling { get; set; }
}
