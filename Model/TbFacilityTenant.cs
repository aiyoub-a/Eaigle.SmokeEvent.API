using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbFacilityTenant
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public int? TenantFacilityId { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbFacility? TenantFacility { get; set; }
}
