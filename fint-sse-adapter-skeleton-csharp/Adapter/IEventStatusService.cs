using FintEventModel.Model;

namespace fint_sse_adapter_skeleton_csharp.Adapter
{
    public interface IEventStatusService
    {
        Event VerifyEvent(Event evt);
    }
}