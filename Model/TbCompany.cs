using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public string? Code { get; set; }

    public string? TemperatureFormat { get; set; }

    public int MaxNumberOfEmailNotifications { get; set; }

    public int MaxNumberOfEmailsPerEmailNotification { get; set; }

    public bool? AskForHostActive { get; set; }

    public bool? FastQuestionnaireActive { get; set; }

    public virtual ICollection<TbActionLog> TbActionLogs { get; } = new List<TbActionLog>();

    public virtual ICollection<TbAlertEmailAddress> TbAlertEmailAddresses { get; } = new List<TbAlertEmailAddress>();

    public virtual ICollection<TbCompanyPersonTypeName> TbCompanyPersonTypeNames { get; } = new List<TbCompanyPersonTypeName>();

    public virtual ICollection<TbCompanyQuestionnaire> TbCompanyQuestionnaires { get; } = new List<TbCompanyQuestionnaire>();

    public virtual ICollection<TbCompanyVisitorProfile> TbCompanyVisitorProfiles { get; } = new List<TbCompanyVisitorProfile>();

    public virtual ICollection<TbEmailNotification> TbEmailNotifications { get; } = new List<TbEmailNotification>();

    public virtual ICollection<TbEmployee> TbEmployees { get; } = new List<TbEmployee>();

    public virtual ICollection<TbFacility> TbFacilities { get; } = new List<TbFacility>();

    public virtual ICollection<TbUserAccessToCompanyQuestionnaire> TbUserAccessToCompanyQuestionnaires { get; } = new List<TbUserAccessToCompanyQuestionnaire>();

    public virtual ICollection<TbVisitorEntry> TbVisitorEntries { get; } = new List<TbVisitorEntry>();
}
