using fint_sse_adapter_skeleton_csharp.Adapter.service;
using fint_sse_adapter_skeleton_csharp.Customcode;
using FintEventModel.Model;
using System;

namespace fint_sse_adapter_skeleton_csharp.Adapter
{
    public class EventStatusService : IEventStatusService
    {
        private IHttpService _httpService;
        private IConfigService _configService;

        public EventStatusService(IHttpService httpService, IConfigService configService)
        {
            _httpService = httpService;
            _configService = configService;
        }

        public Event VerifyEvent(Event evt)
        {
            if (ActionUtils.IsValidAction(evt.Action))
            {
                evt.Status = Status.PROVIDER_ACCEPTED;
            }
            else
            {
                evt.Status = Status.PROVIDER_REJECTED;
            }
            postStatus(evt);
            return evt;
        }

        private void postStatus(Event evt)
        {
            _httpService.Post(_configService.StatusEndpoint, evt);
        }
    }
}
