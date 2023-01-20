using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbSwimmingPoolRecord
{
    public int Id { get; set; }

    public int SwimmingPoolId { get; set; }

    public DateTime DateTimeFrom { get; set; }

    public DateTime DateTimeTo { get; set; }

    public string? OccupancyData { get; set; }

    public string? WaterQualityData { get; set; }

    public string? WaterUseData { get; set; }

    public byte[]? HeatmapData { get; set; }

    public virtual TbSwimmingPool SwimmingPool { get; set; } = null!;
}
