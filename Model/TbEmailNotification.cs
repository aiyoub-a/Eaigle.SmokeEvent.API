using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbEmailNotification
{
    public int Id { get; set; }

    public string? Body { get; set; }

    public int? CompanyId { get; set; }

    public int? CompanyQuestionnaireId { get; set; }

    public bool? Active { get; set; }

    public bool? FridayActive { get; set; }

    public DateTime FridayTime { get; set; }

    public bool? LinkedToQuestionnaire { get; set; }

    public bool? MondayActive { get; set; }

    public DateTime MondayTime { get; set; }

    public bool? SaturdayActive { get; set; }

    public DateTime SaturdayTime { get; set; }

    public bool? SundayActive { get; set; }

    public DateTime SundayTime { get; set; }

    public bool? ThursdayActive { get; set; }

    public DateTime ThursdayTime { get; set; }

    public bool? TuesdayActive { get; set; }

    public DateTime TuesdayTime { get; set; }

    public bool? WednesdayActive { get; set; }

    public DateTime WednesdayTime { get; set; }

    public DateTime LastDateTimeEmailSent { get; set; }

    public int TimeZoneOffsetMinutes { get; set; }

    public string? TimeZoneId { get; set; }

    public bool? TextMessage { get; set; }

    public int? FacilityId { get; set; }

    public string? Creator { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? LastEditor { get; set; }

    public bool? FridayRepeatWeekly { get; set; }

    public bool? MondayRepeatWeekly { get; set; }

    public bool? SaturdayRepeatWeekly { get; set; }

    public string? Subject { get; set; }

    public bool? SundayRepeatWeekly { get; set; }

    public bool? ThursdayRepeatWeekly { get; set; }

    public bool? TuesdayRepeatWeekly { get; set; }

    public bool? WednesdayRepeatWeekly { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbCompanyQuestionnaire? CompanyQuestionnaire { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual ICollection<TbAssignEmailNotificationToEmployee> TbAssignEmailNotificationToEmployees { get; } = new List<TbAssignEmailNotificationToEmployee>();
}
