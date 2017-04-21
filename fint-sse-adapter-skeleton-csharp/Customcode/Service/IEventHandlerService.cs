using FintEventModel.Model;

namespace fint_sse_adapter_skeleton_csharp.Customcode.Service
{
    public interface IEventHandlerService
    {
        void HandleEvent(Event evtObj);
    }
}