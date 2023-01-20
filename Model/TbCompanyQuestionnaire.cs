using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbCompanyQuestionnaire
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CompanyId { get; set; }

    public bool Active { get; set; }

    public bool AskForEmployeeId { get; set; }

    public bool AskForFullName { get; set; }

    public bool AskForEmail { get; set; }

    public bool AskForPhone { get; set; }

    public string? QuestionsJson { get; set; }

    public int? FacilityId { get; set; }

    public string? FacilitiesSeeingTemplate { get; set; }

    public bool? IsTemplate { get; set; }

    public DateTime CreationDateTime { get; set; }

    public string? Creator { get; set; }

    public DateTime ModificationDateTime { get; set; }

    public bool? IsForVisitors { get; set; }

    public int? PersonTypeId { get; set; }

    public string? Language { get; set; }

    public string? AgeRange { get; set; }

    public bool? AskForVisitorCompany { get; set; }

    public string? Code { get; set; }

    public bool? EmailEntryMandatory { get; set; }

    public bool? IsForVaccineCertificateVerified { get; set; }

    public string? AlertMessage { get; set; }

    public string? NormalMessage { get; set; }

    public string? OtherPersonalInformation { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbPersonType? PersonType { get; set; }

    public virtual ICollection<TbAssociationOfServiceStationsAndQuestionnaire> TbAssociationOfServiceStationsAndQuestionnaires { get; } = new List<TbAssociationOfServiceStationsAndQuestionnaire>();

    public virtual ICollection<TbEmailNotification> TbEmailNotifications { get; } = new List<TbEmailNotification>();

    public virtual ICollection<TbEmployee> TbEmployees { get; } = new List<TbEmployee>();

    public virtual ICollection<TbQuestionnaireSubmission> TbQuestionnaireSubmissions { get; } = new List<TbQuestionnaireSubmission>();
}
