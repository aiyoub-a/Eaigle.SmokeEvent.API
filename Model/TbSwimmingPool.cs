using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbSwimmingPool
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int FacilityId { get; set; }

    public int ServiceStationId { get; set; }

    public string? OccupancyData { get; set; }

    public string? WaterQualityData { get; set; }

    public string? WaterUseData { get; set; }

    public string? Information { get; set; }

    public byte[]? Layout { get; set; }

    public string? HeatMapPointsData { get; set; }

    public float HeatMapResolution { get; set; }

    public DateTime LatestDataUpdate { get; set; }

    public byte[]? HeatmapData { get; set; }

    public string? Code { get; set; }

    public virtual TbFacility Facility { get; set; } = null!;

    public virtual TbServiceStation ServiceStation { get; set; } = null!;

    public virtual ICollection<TbSwimmingPoolRecord> TbSwimmingPoolRecords { get; } = new List<TbSwimmingPoolRecord>();
}
