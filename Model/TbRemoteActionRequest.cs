using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbRemoteActionRequest
{
    public int Id { get; set; }

    public int? ServiceStationTypeId { get; set; }

    public int? RemoteActionRequestTypeId { get; set; }

    public DateTime DateTimeRequestRegistered { get; set; }

    public DateTime DateTimeRequestActivation { get; set; }

    public bool RequestReceived { get; set; }

    public DateTime DateTimeRequestReceived { get; set; }

    public bool RequestProcessed { get; set; }

    public DateTime DateTimeRequestProcessed { get; set; }

    public string? Creator { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? LastEditor { get; set; }

    public virtual TbRemoteActionRequestType? RemoteActionRequestType { get; set; }

    public virtual TbServiceStation? ServiceStationType { get; set; }
}
