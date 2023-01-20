using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationTypeParameter
{
    public int Id { get; set; }

    public int ServiceStationTypeId { get; set; }

    public string? Name { get; set; }

    public string? DataType { get; set; }

    public string? ValueOptions { get; set; }

    public string? DefaultValue { get; set; }

    public string? DisplayName { get; set; }

    public virtual TbServiceStationType ServiceStationType { get; set; } = null!;
}
