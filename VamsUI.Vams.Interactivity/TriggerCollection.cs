using System.Windows;

namespace VamsUI.Vams.Interactivity;

public sealed class TriggerCollection : AttachableCollection<TriggerBase>
{
    internal TriggerCollection()
    {
    }

    protected override void OnAttached()
    {
        foreach (var triggerBase in this)
            triggerBase.Attach(AssociatedObject);
    }

    protected override void OnDetaching()
    {
        foreach (var triggerBase in this)
            triggerBase.Detach();
    }

    public override void ItemAdded(TriggerBase item)
    {
        if (AssociatedObject == null)
            return;
        item.Attach(AssociatedObject);
    }

    public override void ItemRemoved(TriggerBase item)
    {
        if (((IAttachedObject) item).AssociatedObject == null)
            return;
        item.Detach();
    }

    protected override Freezable CreateInstanceCore()
    {
        return new TriggerCollection();
    }
}
