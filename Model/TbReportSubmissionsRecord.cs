using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbReportSubmissionsRecord
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public int? FacilityId { get; set; }

    public DateTime SubmissionDateTime { get; set; }

    public string? Data { get; set; }

    public virtual TbFacility? Facility { get; set; }
}
