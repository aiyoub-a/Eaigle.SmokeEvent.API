using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbOccupancy
{
    public int Id { get; set; }

    public byte[]? Layout { get; set; }

    public byte[]? HeatmapData { get; set; }

    public string? HeatMapPointsData { get; set; }

    public float HeatMapResolution { get; set; }

    public string? OccupancyDataDaily { get; set; }

    public string? OccupancyDataHourly { get; set; }

    public string? OccupancyDataMinutely { get; set; }

    public DateTime LatestDataUpdate { get; set; }

    public int? AreaId { get; set; }

    public virtual TbArea? Area { get; set; }
}
