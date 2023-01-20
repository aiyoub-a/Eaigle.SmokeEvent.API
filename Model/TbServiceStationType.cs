using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public virtual ICollection<TbRemoteActionRequestType> TbRemoteActionRequestTypes { get; } = new List<TbRemoteActionRequestType>();

    public virtual ICollection<TbServiceStationTypeParameter> TbServiceStationTypeParameters { get; } = new List<TbServiceStationTypeParameter>();

    public virtual ICollection<TbServiceStation> TbServiceStations { get; } = new List<TbServiceStation>();
}
