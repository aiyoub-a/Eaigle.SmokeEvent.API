using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbFacility
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public int FacilityTypeId { get; set; }

    public int? CompanyId { get; set; }

    public int MinutesDifferenceToUtc { get; set; }

    public string? FacilityCode { get; set; }

    public string? Parameters { get; set; }

    public bool? VisitorPackage { get; set; }

    public bool? VerifyEmployeeId { get; set; }

    public bool? VaccineCertificateVerificationPackage { get; set; }

    public int CapacityVisitors { get; set; }

    public bool? AskQuestionForVaccination { get; set; }

    public bool? SendAlertEmailToHostOnVisitorCheckIn { get; set; }

    public bool? VaccineProofNeededToLetPeopleIn { get; set; }

    public string? EmployeesOtherInformationJson { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbFacilityType FacilityType { get; set; } = null!;

    public virtual ICollection<TbActionLog> TbActionLogs { get; } = new List<TbActionLog>();

    public virtual ICollection<TbArea> TbAreas { get; } = new List<TbArea>();

    public virtual ICollection<TbCompanyQuestionnaire> TbCompanyQuestionnaires { get; } = new List<TbCompanyQuestionnaire>();

    public virtual ICollection<TbEmailNotification> TbEmailNotifications { get; } = new List<TbEmailNotification>();

    public virtual ICollection<TbEmployee> TbEmployees { get; } = new List<TbEmployee>();

    public virtual ICollection<TbFacilityTenant> TbFacilityTenantFacilities { get; } = new List<TbFacilityTenant>();

    public virtual ICollection<TbFacilityTenant> TbFacilityTenantTenantFacilities { get; } = new List<TbFacilityTenant>();

    public virtual ICollection<TbOperationTask> TbOperationTasks { get; } = new List<TbOperationTask>();

    public virtual ICollection<TbPackage> TbPackages { get; } = new List<TbPackage>();

    public virtual ICollection<TbQuestionnaireEmailReport> TbQuestionnaireEmailReports { get; } = new List<TbQuestionnaireEmailReport>();

    public virtual ICollection<TbReportSubmissionsRecord> TbReportSubmissionsRecords { get; } = new List<TbReportSubmissionsRecord>();

    public virtual ICollection<TbServiceStation> TbServiceStations { get; } = new List<TbServiceStation>();

    public virtual ICollection<TbSmokeEvent> TbSmokeEvents { get; } = new List<TbSmokeEvent>();

    public virtual ICollection<TbSwimmingPool> TbSwimmingPools { get; } = new List<TbSwimmingPool>();

    public virtual ICollection<TbTermAndConditionAgreement> TbTermAndConditionAgreements { get; } = new List<TbTermAndConditionAgreement>();

    public virtual ICollection<TbVisitorEntry> TbVisitorEntries { get; } = new List<TbVisitorEntry>();
}
