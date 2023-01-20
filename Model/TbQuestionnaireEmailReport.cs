using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbQuestionnaireEmailReport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? FacilityId { get; set; }

    public int Minutes { get; set; }

    public DateTime LastDateTimeReportGenerated { get; set; }

    public string? ListOfEmailsJson { get; set; }

    public string? ListOfFiledsJson { get; set; }

    public string? ListOfPersonTypesJson { get; set; }

    public string? Creator { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public bool Scanned { get; set; }

    public bool? LockedForEmailSendingProcess { get; set; }

    public DateTime TimeTimeOfLocking { get; set; }

    public virtual TbFacility? Facility { get; set; }
}
