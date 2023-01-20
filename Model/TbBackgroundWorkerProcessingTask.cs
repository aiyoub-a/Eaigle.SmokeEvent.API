using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbBackgroundWorkerProcessingTask
{
    public int Id { get; set; }

    public string? TaskName { get; set; }

    public DateTime LastDateTimeTaskExecuted { get; set; }

    public int PeriodRunningTaskSeconds { get; set; }
}
