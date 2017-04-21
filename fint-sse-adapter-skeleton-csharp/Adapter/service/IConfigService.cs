using System.Collections.Generic;

namespace fint_sse_adapter_skeleton_csharp.Adapter.service
{
    public interface IConfigService
    {
        string LogLocation { get; }
        IEnumerable<string> Organizations { get; }
        string ResponseEndpoint { get; }
        string SseEndpoint { get; }
        string StatusEndpoint { get; }
    }
}