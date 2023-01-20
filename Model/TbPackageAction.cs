using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPackageAction
{
    public int Id { get; set; }

    public int? PackageId { get; set; }

    public int? PackageActionTypeId { get; set; }

    public int? ChecklistId { get; set; }

    public string? ReferenceCode { get; set; }

    public string? UserCreator { get; set; }

    public string? UserOperator { get; set; }

    public string? UserAssignee { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime FinishedDateTime { get; set; }

    public string? Parameters { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public virtual TbPackage? Package { get; set; }

    public virtual TbPackageActionType? PackageActionType { get; set; }
}
