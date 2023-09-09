﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace VamsUI.Vams.Data;

/// <summary>
///     装箱后的值类型（用于提高效率）
/// </summary>
public static class ValueBoxes
{
    public static object TrueBox = true;

    public static object FalseBox = false;

    public static object VerticalBox = Orientation.Vertical;

    public static object HorizontalBox = Orientation.Horizontal;

    public static object VisibleBox = Visibility.Visible;

    public static object CollapsedBox = Visibility.Collapsed;

    public static object HiddenBox = Visibility.Hidden;

    public static object Double01Box = .1;

    public static object Double0Box = .0;

    public static object Double1Box = 1.0;

    public static object Double10Box = 10.0;

    public static object Double20Box = 20.0;

    public static object Double100Box = 100.0;

    public static object Double200Box = 200.0;

    public static object Double300Box = 300.0;

    public static object DoubleNeg1Box = -1.0;

    public static object Int0Box = 0;

    public static object Int1Box = 1;

    public static object Int2Box = 2;

    public static object Int5Box = 5;

    public static object Int99Box = 99;

    public static object BooleanBox(bool value) => value ? TrueBox : FalseBox;

    public static object OrientationBox(Orientation value) =>
        value == Orientation.Horizontal ? HorizontalBox : VerticalBox;

    public static object VisibilityBox(Visibility value)
    {
        return value switch
        {
            Visibility.Visible => VisibleBox,
            Visibility.Hidden => HiddenBox,
            Visibility.Collapsed => CollapsedBox,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
    }
}
