using FintEventModel.Model;

namespace fint_sse_adapter_skeleton_csharp.Adapter.service
{
    public interface IHttpService
    {
        void Post(string endpoint, Event evt);
    }
}