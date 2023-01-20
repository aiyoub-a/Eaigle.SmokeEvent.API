using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbQuestionnaireSubmission
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime DateTypeSubmission { get; set; }

    public int? CompaniesQuestionnaireId { get; set; }

    public string? AnswersJson { get; set; }

    public string? Info { get; set; }

    public string? State { get; set; }

    public int? AreaId { get; set; }

    public string? NoteForVisitor { get; set; }

    public int? VisitingEmployeeId { get; set; }

    public int? RequestedVisitingEmployeeId { get; set; }

    public DateTime ActionTakenDateTimeFroVisitor { get; set; }

    public string? ActionTakerForVisitor { get; set; }

    public string? VisitorCompany { get; set; }

    public DateTime DateTimeCheckIn { get; set; }

    public DateTime DateTimeCheckOut { get; set; }

    public bool? CheckedOut { get; set; }

    public DateTime DateTimeCheckoutNotificationSent { get; set; }

    public bool? VisitorCheckInNotificationSent { get; set; }

    public string? OtherInformation { get; set; }

    public string? Tags { get; set; }

    public virtual TbArea? Area { get; set; }

    public virtual TbCompanyQuestionnaire? CompaniesQuestionnaire { get; set; }

    public virtual TbEmployee? RequestedVisitingEmployee { get; set; }

    public virtual TbEmployee? VisitingEmployee { get; set; }
}
