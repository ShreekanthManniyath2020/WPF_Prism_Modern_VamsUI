using System;
using System.Windows.Media.Effects;

namespace VamsUI.Vams.Media.Effects;

public class ColorComplementEffect : EffectBase
{
    private static readonly PixelShader Shader;

    static ColorComplementEffect()
    {
        Shader = new PixelShader
        {
            UriSource = new Uri("pack://application:,,,/VamsUI.Vams;component/Resources/Effects/ColorComplementEffect.ps")
        };
    }

    public ColorComplementEffect()
    {
        PixelShader = Shader;

        UpdateShaderValue(InputProperty);
    }
}
