using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPackage
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public string Name { get; set; } = null!;

    public int? PackageTypeId { get; set; }

    public string? Creator { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbPackageType? PackageType { get; set; }

    public virtual ICollection<TbOperationTask> TbOperationTasks { get; } = new List<TbOperationTask>();

    public virtual ICollection<TbPackageAction> TbPackageActions { get; } = new List<TbPackageAction>();

    public virtual ICollection<TbPackageServiceStation> TbPackageServiceStations { get; } = new List<TbPackageServiceStation>();
}
