using Prism.Mvvm;
using Prism.Navigation;

namespace VamsUI.Vams.PrismDemo.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
