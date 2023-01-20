using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAlertEmailAddress
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? EmailAddress { get; set; }

    public string? FacilityIdsJson { get; set; }

    public bool FeverAlerts { get; set; }

    public bool QuestionnaireAlerts { get; set; }

    public bool AttachImage { get; set; }

    public string? Creator { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public bool? VaccineCertificateSubmissionAlerts { get; set; }

    public bool? VisitorAlerts { get; set; }

    public bool? PrinterOutOfPaperAlerts { get; set; }

    public string? QuestionnaireAlertsPersonTypesJson { get; set; }

    public bool? SmokeAlerts { get; set; }

    public virtual TbCompany? Company { get; set; }
}
