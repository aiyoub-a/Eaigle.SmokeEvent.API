using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStationCompanyVisitorProfileMapping
{
    public int Id { get; set; }

    public int ServiceStationId { get; set; }

    public int CompanyVisitorProfileId { get; set; }

    public virtual TbCompanyVisitorProfile CompanyVisitorProfile { get; set; } = null!;

    public virtual TbServiceStation ServiceStation { get; set; } = null!;
}
