using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.Framework
{
    public interface IDetailViewModel : IViewAware, IHaveModel, IChild, IHaveViewNamedElements, IHaveShutdownTask,
        IRefreshTranslation
    {
    }
}