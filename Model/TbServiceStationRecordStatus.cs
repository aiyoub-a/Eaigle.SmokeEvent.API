using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationRecordStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TbServiceStationRecord> TbServiceStationRecords { get; } = new List<TbServiceStationRecord>();
}
