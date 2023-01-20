using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbChecklist
{
    public int Id { get; set; }

    public int Order { get; set; }

    public string? Name { get; set; }

    public int? PackageTypeId { get; set; }

    public virtual TbPackageType? PackageType { get; set; }

    public virtual ICollection<TbChecklistItem> TbChecklistItems { get; } = new List<TbChecklistItem>();

    public virtual ICollection<TbOperationTask> TbOperationTasks { get; } = new List<TbOperationTask>();
}
