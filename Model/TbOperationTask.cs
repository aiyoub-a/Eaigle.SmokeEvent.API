using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbOperationTask
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public int? PackageId { get; set; }

    public int? ChecklistId { get; set; }

    public string? UserId { get; set; }

    public DateTime DateTimeCreated { get; set; }

    public DateTime DateTimeFinished { get; set; }

    public string? Status { get; set; }

    public string? Creator { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public virtual TbChecklist? Checklist { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbPackage? Package { get; set; }

    public virtual AspNetUser? User { get; set; }
}
