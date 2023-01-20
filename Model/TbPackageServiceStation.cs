using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPackageServiceStation
{
    public int Id { get; set; }

    public int? PackageId { get; set; }

    public int? ServiceStationId { get; set; }

    public virtual TbPackage? Package { get; set; }

    public virtual TbServiceStation? ServiceStation { get; set; }
}
