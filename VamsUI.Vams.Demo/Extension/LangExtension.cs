using VamsUI.Vams.Properties.Langs;

namespace VamsUI.VamsDemo.Tools.Extension;

public class LangExtension : VamsUI.Vams.Tools.Extension.LangExtension
{
    public LangExtension()
    {
        Source = LangProvider.Instance;
    }
}
