using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationRecord
{
    public int Id { get; set; }

    public int? ServiceStationRecordTypeId { get; set; }

    public int? ServiceStationId { get; set; }

    public DateTime DateTimeRecorded { get; set; }

    public string? Info { get; set; }

    public int? StatusId { get; set; }

    public bool? Reported { get; set; }

    public virtual TbServiceStation? ServiceStation { get; set; }

    public virtual TbServiceStationRecordType? ServiceStationRecordType { get; set; }

    public virtual TbServiceStationRecordStatus? Status { get; set; }
}
