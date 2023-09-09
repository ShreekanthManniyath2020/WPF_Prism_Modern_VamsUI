using System.Windows.Media;

namespace VamsUI.Vams.Expression.Media;

public interface IGeometrySourceParameters
{
    Stretch Stretch { get; }

    Brush Stroke { get; }

    double StrokeThickness { get; }
}
