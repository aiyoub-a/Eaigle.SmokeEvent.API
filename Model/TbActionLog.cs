using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbActionLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? ActionController { get; set; }

    public string? ActionName { get; set; }

    public string? ActionInfo { get; set; }

    public DateTime ActionDateTime { get; set; }

    public int? CompanyId { get; set; }

    public int? FacilityId { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual AspNetUser? User { get; set; }
}
