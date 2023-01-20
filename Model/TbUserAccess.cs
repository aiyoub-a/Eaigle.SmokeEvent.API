using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbUserAccess
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int ServiceStationId { get; set; }

    public bool AccessSuspended { get; set; }

    public virtual TbServiceStation ServiceStation { get; set; } = null!;

    public virtual AspNetUser? User { get; set; }
}
