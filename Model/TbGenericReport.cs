using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbGenericReport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? FacilitiesArray { get; set; }

    public string? Parameters { get; set; }

    public string? EmailAddressesArray { get; set; }

    public DateTime LastDateTimeReportSent { get; set; }

    public string? DaysTimesReportToBeSentArray { get; set; }
}
