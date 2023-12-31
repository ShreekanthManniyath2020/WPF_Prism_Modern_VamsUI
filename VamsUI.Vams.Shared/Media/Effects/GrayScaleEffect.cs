﻿using System;
using System.Windows;
using System.Windows.Media.Effects;
using VamsUI.Vams.Data;

namespace VamsUI.Vams.Media.Effects;

public class GrayScaleEffect : EffectBase
{
    private static readonly PixelShader Shader;

    static GrayScaleEffect()
    {
        Shader = new PixelShader
        {
            UriSource = new Uri("pack://application:,,,/VamsUI.Vams;component/Resources/Effects/GrayScaleEffect.ps")
        };
    }

    public GrayScaleEffect()
    {
        PixelShader = Shader;

        UpdateShaderValue(InputProperty);
        UpdateShaderValue(ScaleProperty);
    }

    public static readonly DependencyProperty ScaleProperty = DependencyProperty.Register(
        nameof(Scale), typeof(double), typeof(GrayScaleEffect), new PropertyMetadata(ValueBoxes.Double1Box, PixelShaderConstantCallback(0)));

    public double Scale
    {
        get => (double) GetValue(ScaleProperty);
        set => SetValue(ScaleProperty, value);
    }
}
