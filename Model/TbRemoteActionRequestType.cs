using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbRemoteActionRequestType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ScriptName { get; set; } = null!;

    public int ServiceStationTypeId { get; set; }

    public virtual TbServiceStationType ServiceStationType { get; set; } = null!;

    public virtual ICollection<TbRemoteActionRequest> TbRemoteActionRequests { get; } = new List<TbRemoteActionRequest>();
}
