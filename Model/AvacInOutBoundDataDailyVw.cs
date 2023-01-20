using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class AvacInOutBoundDataDailyVw
{
    public int? DateTimeSubmitted { get; set; }

    public int? InBound { get; set; }

    public int? OutBound { get; set; }
}
