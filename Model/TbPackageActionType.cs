using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPackageActionType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TbPackageAction> TbPackageActions { get; } = new List<TbPackageAction>();
}
