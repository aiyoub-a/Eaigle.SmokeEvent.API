using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbFacilityType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public virtual ICollection<TbFacility> TbFacilities { get; } = new List<TbFacility>();

    public virtual ICollection<TbFacilityTypeParameter> TbFacilityTypeParameters { get; } = new List<TbFacilityTypeParameter>();
}
