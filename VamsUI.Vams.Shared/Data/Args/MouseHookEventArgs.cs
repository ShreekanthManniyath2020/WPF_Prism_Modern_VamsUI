using System;
using VamsUI.Vams.Tools.Interop;

namespace VamsUI.Vams.Data;

internal class MouseHookEventArgs : EventArgs
{
    public MouseHookMessageType MessageType { get; set; }

    public InteropValues.POINT Point { get; set; }
}
