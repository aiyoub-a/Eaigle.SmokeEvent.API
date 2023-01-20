using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationConnection
{
    public int Id { get; set; }

    public int SourceServiceStationId { get; set; }

    public int TargetServiceStationId { get; set; }
}
