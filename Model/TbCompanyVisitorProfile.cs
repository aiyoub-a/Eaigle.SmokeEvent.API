using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbCompanyVisitorProfile
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string ProfileName { get; set; } = null!;

    public string VisitorType { get; set; } = null!;

    public string ProfileDetails { get; set; } = null!;

    public virtual TbCompany Company { get; set; } = null!;

    public virtual ICollection<TbServiceStationCompanyVisitorProfileMapping> TbServiceStationCompanyVisitorProfileMappings { get; } = new List<TbServiceStationCompanyVisitorProfileMapping>();

    public virtual ICollection<TbVisitorEntry> TbVisitorEntries { get; } = new List<TbVisitorEntry>();
}
