using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPackageType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TbChecklist> TbChecklists { get; } = new List<TbChecklist>();

    public virtual ICollection<TbPackage> TbPackages { get; } = new List<TbPackage>();
}
