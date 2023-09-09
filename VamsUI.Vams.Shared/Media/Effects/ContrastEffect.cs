using System;
using System.Windows;
using System.Windows.Media.Effects;
using VamsUI.Vams.Data;

namespace VamsUI.Vams.Media.Effects;

public class ContrastEffect : EffectBase
{
    private static readonly PixelShader Shader;

    static ContrastEffect()
    {
        Shader = new PixelShader
        {
            UriSource = new Uri("pack://application:,,,/VamsUI.Vams;component/Resources/Effects/ContrastEffect.ps")
        };
    }

    public ContrastEffect()
    {
        PixelShader = Shader;

        UpdateShaderValue(InputProperty);
        UpdateShaderValue(ContrastProperty);
    }

    public static readonly DependencyProperty ContrastProperty = DependencyProperty.Register(
        nameof(Contrast), typeof(double), typeof(ContrastEffect), new PropertyMetadata(ValueBoxes.Double1Box, PixelShaderConstantCallback(0)));

    public double Contrast
    {
        get => (double) GetValue(ContrastProperty);
        set => SetValue(ContrastProperty, value);
    }
}
