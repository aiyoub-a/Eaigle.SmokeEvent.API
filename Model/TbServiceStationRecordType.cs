using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationRecordType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public virtual ICollection<TbServiceStationRecord> TbServiceStationRecords { get; } = new List<TbServiceStationRecord>();
}
