using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAssignEmailNotificationToEmployee
{
    public int Id { get; set; }

    public int? EmailNotificationId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual TbEmailNotification? EmailNotification { get; set; }

    public virtual TbEmployee? Employee { get; set; }
}
