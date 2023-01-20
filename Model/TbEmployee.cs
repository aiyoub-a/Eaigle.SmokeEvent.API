using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbEmployee
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Email { get; set; }

    public string? EmployeeCode { get; set; }

    public bool? Active { get; set; }

    public string? Department { get; set; }

    public int? MyCompanyId { get; set; }

    public string? PhoneNumber { get; set; }

    public int? MyFacilityId { get; set; }

    public bool? IsVisitable { get; set; }

    public string? BadgeCode { get; set; }

    public string? Creator { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? LastEditor { get; set; }

    public int? AssignedCompanyQuestionnaireId { get; set; }

    public string? AuxCode { get; set; }

    public byte[]? DataFile1 { get; set; }

    public byte[]? DataFile2 { get; set; }

    public DateTime? FileCreatedDateTime1 { get; set; }

    public DateTime? FileCreatedDateTime2 { get; set; }

    public string? FileType1 { get; set; }

    public string? FileType2 { get; set; }

    public bool? VaccineCertificateVerified { get; set; }

    public string? VaccineCertificateVerifiedBy { get; set; }

    public bool? SendAlertForVaccineCertificateSubmission { get; set; }

    public byte[]? PersonalPhoto { get; set; }

    public string? PersonalPhotoType { get; set; }

    public string? ExtractedDataFromDocument { get; set; }

    public bool? InitialVerificationOfVaccineCertificateDone { get; set; }

    public bool? StrongInitialVerificationOfVaccineCertificateDone { get; set; }

    public string? EmployeesOtherInformationJson { get; set; }

    public virtual TbCompanyQuestionnaire? AssignedCompanyQuestionnaire { get; set; }

    public virtual TbCompany? MyCompany { get; set; }

    public virtual TbFacility? MyFacility { get; set; }

    public virtual ICollection<TbAssignEmailNotificationToEmployee> TbAssignEmailNotificationToEmployees { get; } = new List<TbAssignEmailNotificationToEmployee>();

    public virtual ICollection<TbQuestionnaireSubmission> TbQuestionnaireSubmissionRequestedVisitingEmployees { get; } = new List<TbQuestionnaireSubmission>();

    public virtual ICollection<TbQuestionnaireSubmission> TbQuestionnaireSubmissionVisitingEmployees { get; } = new List<TbQuestionnaireSubmission>();
}
