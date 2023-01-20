using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Eaigle.SmokeEvent.API.Model;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<AvacInOutBoundDataDailyVw> AvacInOutBoundDataDailyVws { get; set; }

    public virtual DbSet<TbActionLog> TbActionLogs { get; set; }

    public virtual DbSet<TbAlertEmailAddress> TbAlertEmailAddresses { get; set; }

    public virtual DbSet<TbArea> TbAreas { get; set; }

    public virtual DbSet<TbAreaType> TbAreaTypes { get; set; }

    public virtual DbSet<TbAssignEmailNotificationToEmployee> TbAssignEmailNotificationToEmployees { get; set; }

    public virtual DbSet<TbAssociateTermsAndConditionsToServiceStation> TbAssociateTermsAndConditionsToServiceStations { get; set; }

    public virtual DbSet<TbAssociationOfServiceStationsAndQuestionnaire> TbAssociationOfServiceStationsAndQuestionnaires { get; set; }

    public virtual DbSet<TbAvacdocument> TbAvacdocuments { get; set; }

    public virtual DbSet<TbAvacdocumentType> TbAvacdocumentTypes { get; set; }

    public virtual DbSet<TbAvacpersonType> TbAvacpersonTypes { get; set; }

    public virtual DbSet<TbBackgroundWorkerProcessingTask> TbBackgroundWorkerProcessingTasks { get; set; }

    public virtual DbSet<TbChecklist> TbChecklists { get; set; }

    public virtual DbSet<TbChecklistItem> TbChecklistItems { get; set; }

    public virtual DbSet<TbCompany> TbCompanies { get; set; }

    public virtual DbSet<TbCompanyPersonTypeName> TbCompanyPersonTypeNames { get; set; }

    public virtual DbSet<TbCompanyQuestionnaire> TbCompanyQuestionnaires { get; set; }

    public virtual DbSet<TbCompanyVisitorProfile> TbCompanyVisitorProfiles { get; set; }

    public virtual DbSet<TbEmailNotification> TbEmailNotifications { get; set; }

    public virtual DbSet<TbEmployee> TbEmployees { get; set; }

    public virtual DbSet<TbFacility> TbFacilities { get; set; }

    public virtual DbSet<TbFacilityTenant> TbFacilityTenants { get; set; }

    public virtual DbSet<TbFacilityType> TbFacilityTypes { get; set; }

    public virtual DbSet<TbFacilityTypeParameter> TbFacilityTypeParameters { get; set; }

    public virtual DbSet<TbGenericReport> TbGenericReports { get; set; }

    public virtual DbSet<TbMenu> TbMenus { get; set; }

    public virtual DbSet<TbOccupancy> TbOccupancies { get; set; }

    public virtual DbSet<TbOperationTask> TbOperationTasks { get; set; }

    public virtual DbSet<TbPackage> TbPackages { get; set; }

    public virtual DbSet<TbPackageAction> TbPackageActions { get; set; }

    public virtual DbSet<TbPackageActionType> TbPackageActionTypes { get; set; }

    public virtual DbSet<TbPackageServiceStation> TbPackageServiceStations { get; set; }

    public virtual DbSet<TbPackageType> TbPackageTypes { get; set; }

    public virtual DbSet<TbPersonType> TbPersonTypes { get; set; }

    public virtual DbSet<TbQuestionnaireEmailReport> TbQuestionnaireEmailReports { get; set; }

    public virtual DbSet<TbQuestionnaireSubmission> TbQuestionnaireSubmissions { get; set; }

    public virtual DbSet<TbRemoteActionRequest> TbRemoteActionRequests { get; set; }

    public virtual DbSet<TbRemoteActionRequestType> TbRemoteActionRequestTypes { get; set; }

    public virtual DbSet<TbReportSubmissionsRecord> TbReportSubmissionsRecords { get; set; }

    public virtual DbSet<TbServiceStation> TbServiceStations { get; set; }

    public virtual DbSet<TbServiceStationCompanyVisitorProfileMapping> TbServiceStationCompanyVisitorProfileMappings { get; set; }

    public virtual DbSet<TbServiceStationConnection> TbServiceStationConnections { get; set; }

    public virtual DbSet<TbServiceStationRecord> TbServiceStationRecords { get; set; }

    public virtual DbSet<TbServiceStationRecordStatus> TbServiceStationRecordStatuses { get; set; }

    public virtual DbSet<TbServiceStationRecordType> TbServiceStationRecordTypes { get; set; }

    public virtual DbSet<TbServiceStationType> TbServiceStationTypes { get; set; }

    public virtual DbSet<TbServiceStationTypeParameter> TbServiceStationTypeParameters { get; set; }

    public virtual DbSet<TbSmokeEvent> TbSmokeEvents { get; set; }

    public virtual DbSet<TbSwimmingPool> TbSwimmingPools { get; set; }

    public virtual DbSet<TbSwimmingPoolRecord> TbSwimmingPoolRecords { get; set; }

    public virtual DbSet<TbTermAndConditionAgreement> TbTermAndConditionAgreements { get; set; }

    public virtual DbSet<TbTruckTrailerCompany> TbTruckTrailerCompanies { get; set; }

    public virtual DbSet<TbUserAccess> TbUserAccesses { get; set; }

    public virtual DbSet<TbUserAccessToCompanyQuestionnaire> TbUserAccessToCompanyQuestionnaires { get; set; }

    public virtual DbSet<TbUserLoginDatum> TbUserLoginData { get; set; }

    public virtual DbSet<TbVisitorEntry> TbVisitorEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = tcp:swimmingpooldb.database.windows.net,1433;Database=Eaigle-Development-DB;Uid=EaigleDevelopmentLogin;PwD=N126@htgam.4218;Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("db_accessadmin");

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Discriminator).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.PositionInCompany).HasColumnName("positionInCompany");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AvacInOutBoundDataDailyVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AVAC_InOutBoundData_DAILY_vw");
        });

        modelBuilder.Entity<TbActionLog>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbActionLogs_CompanyId");

            entity.HasIndex(e => e.FacilityId, "IX_TbActionLogs_FacilityId");

            entity.HasIndex(e => e.UserId, "IX_TbActionLogs_UserId");

            entity.HasOne(d => d.Company).WithMany(p => p.TbActionLogs).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbActionLogs).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.User).WithMany(p => p.TbActionLogs).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbAlertEmailAddress>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbAlertEmailAddresses_CompanyId");

            entity.Property(e => e.FacilityIdsJson).HasColumnName("FacilityIdsJSON");
            entity.Property(e => e.FullName).HasDefaultValueSql("(N'')");
            entity.Property(e => e.PrinterOutOfPaperAlerts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.QuestionnaireAlertsPersonTypesJson).HasColumnName("QuestionnaireAlertsPersonTypesJSON");
            entity.Property(e => e.SmokeAlerts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VaccineCertificateSubmissionAlerts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VisitorAlerts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Company).WithMany(p => p.TbAlertEmailAddresses).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<TbArea>(entity =>
        {
            entity.HasIndex(e => e.AreaTypeId, "IX_TbAreas_AreaTypeId");

            entity.HasIndex(e => e.FacilityId, "IX_TbAreas_FacilityId");

            entity.Property(e => e.LastDateTimeModified).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.AreaType).WithMany(p => p.TbAreas).HasForeignKey(d => d.AreaTypeId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbAreas).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<TbAssignEmailNotificationToEmployee>(entity =>
        {
            entity.HasIndex(e => e.EmailNotificationId, "IX_TbAssignEmailNotificationToEmployees_EmailNotificationId");

            entity.HasIndex(e => e.EmployeeId, "IX_TbAssignEmailNotificationToEmployees_EmployeeId");

            entity.HasOne(d => d.EmailNotification).WithMany(p => p.TbAssignEmailNotificationToEmployees).HasForeignKey(d => d.EmailNotificationId);

            entity.HasOne(d => d.Employee).WithMany(p => p.TbAssignEmailNotificationToEmployees).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<TbAssociateTermsAndConditionsToServiceStation>(entity =>
        {
            entity.HasIndex(e => e.ServiceStationId, "IX_TbAssociateTermsAndConditionsToServiceStations_ServiceStationId");

            entity.HasIndex(e => e.TermAndConditionAgreementId, "IX_TbAssociateTermsAndConditionsToServiceStations_TermAndConditionAgreementId");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbAssociateTermsAndConditionsToServiceStations).HasForeignKey(d => d.ServiceStationId);

            entity.HasOne(d => d.TermAndConditionAgreement).WithMany(p => p.TbAssociateTermsAndConditionsToServiceStations).HasForeignKey(d => d.TermAndConditionAgreementId);
        });

        modelBuilder.Entity<TbAssociationOfServiceStationsAndQuestionnaire>(entity =>
        {
            entity.HasIndex(e => e.QuestionnaireId, "IX_TbAssociationOfServiceStationsAndQuestionnaires_QuestionnaireId");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbAssociationOfServiceStationsAndQuestionnaires_ServiceStationId");

            entity.HasOne(d => d.Questionnaire).WithMany(p => p.TbAssociationOfServiceStationsAndQuestionnaires).HasForeignKey(d => d.QuestionnaireId);

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbAssociationOfServiceStationsAndQuestionnaires).HasForeignKey(d => d.ServiceStationId);
        });

        modelBuilder.Entity<TbAvacdocument>(entity =>
        {
            entity.ToTable("TbAVACDocuments");

            entity.HasIndex(e => e.AvacdocumentTypeId, "IX_TbAVACDocuments_AVACDocumentTypeId");

            entity.HasIndex(e => e.VisitorEntryId, "IX_TbAVACDocuments_VisitorEntryId");

            entity.Property(e => e.AvacdocumentTypeId).HasColumnName("AVACDocumentTypeId");
            entity.Property(e => e.Format).HasMaxLength(100);
            entity.Property(e => e.Path).HasMaxLength(500);

            entity.HasOne(d => d.AvacdocumentType).WithMany(p => p.TbAvacdocuments).HasForeignKey(d => d.AvacdocumentTypeId);

            entity.HasOne(d => d.VisitorEntry).WithMany(p => p.TbAvacdocuments).HasForeignKey(d => d.VisitorEntryId);
        });

        modelBuilder.Entity<TbAvacdocumentType>(entity =>
        {
            entity.ToTable("TbAVACDocumentTypes");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<TbAvacpersonType>(entity =>
        {
            entity.ToTable("TbAVACPersonTypes");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<TbBackgroundWorkerProcessingTask>(entity =>
        {
            entity.Property(e => e.PeriodRunningTaskSeconds).HasColumnName("PeriodRunningTask_Seconds");
        });

        modelBuilder.Entity<TbChecklist>(entity =>
        {
            entity.HasIndex(e => e.PackageTypeId, "IX_TbChecklists_PackageTypeId");

            entity.Property(e => e.Order).HasColumnName("order");

            entity.HasOne(d => d.PackageType).WithMany(p => p.TbChecklists).HasForeignKey(d => d.PackageTypeId);
        });

        modelBuilder.Entity<TbChecklistItem>(entity =>
        {
            entity.HasIndex(e => e.ChecklistId, "IX_TbChecklistItems_ChecklistId");

            entity.Property(e => e.Order).HasColumnName("order");

            entity.HasOne(d => d.Checklist).WithMany(p => p.TbChecklistItems).HasForeignKey(d => d.ChecklistId);
        });

        modelBuilder.Entity<TbCompany>(entity =>
        {
            entity.Property(e => e.AskForHostActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.FastQuestionnaireActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.MaxNumberOfEmailNotifications).HasColumnName("maxNumberOfEmailNotifications");
            entity.Property(e => e.MaxNumberOfEmailsPerEmailNotification).HasColumnName("maxNumberOfEmailsPerEmailNotification");
        });

        modelBuilder.Entity<TbCompanyPersonTypeName>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbCompanyPersonTypeNames_CompanyId");

            entity.HasIndex(e => e.PersonTypeId, "IX_TbCompanyPersonTypeNames_PersonTypeId");

            entity.HasOne(d => d.Company).WithMany(p => p.TbCompanyPersonTypeNames).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.PersonType).WithMany(p => p.TbCompanyPersonTypeNames).HasForeignKey(d => d.PersonTypeId);
        });

        modelBuilder.Entity<TbCompanyQuestionnaire>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbCompanyQuestionnaires_CompanyId");

            entity.HasIndex(e => e.FacilityId, "IX_TbCompanyQuestionnaires_FacilityId");

            entity.HasIndex(e => e.PersonTypeId, "IX_TbCompanyQuestionnaires_PersonTypeId");

            entity.Property(e => e.AskForVisitorCompany)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.CreationDateTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.EmailEntryMandatory)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsForVaccineCertificateVerified)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsForVisitors)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsTemplate)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ModificationDateTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Company).WithMany(p => p.TbCompanyQuestionnaires).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbCompanyQuestionnaires).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.PersonType).WithMany(p => p.TbCompanyQuestionnaires).HasForeignKey(d => d.PersonTypeId);
        });

        modelBuilder.Entity<TbCompanyVisitorProfile>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbCompanyVisitorProfiles_CompanyId");

            entity.Property(e => e.ProfileDetails).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Company).WithMany(p => p.TbCompanyVisitorProfiles).HasForeignKey(d => d.CompanyId);
        });

        modelBuilder.Entity<TbEmailNotification>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbEmailNotifications_CompanyId");

            entity.HasIndex(e => e.CompanyQuestionnaireId, "IX_TbEmailNotifications_CompanyQuestionnaireId");

            entity.HasIndex(e => e.FacilityId, "IX_TbEmailNotifications_FacilityId");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.FridayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.FridayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.FridayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.LastDateTimeEmailSent).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.LastDateTimeModified).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.LinkedToQuestionnaire)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.MondayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.MondayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.MondayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.SaturdayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SaturdayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SaturdayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.SundayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SundayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SundayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.TextMessage)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ThursdayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ThursdayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ThursdayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.TuesdayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.TuesdayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.TuesdayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.WednesdayActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.WednesdayRepeatWeekly)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.WednesdayTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Company).WithMany(p => p.TbEmailNotifications).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.CompanyQuestionnaire).WithMany(p => p.TbEmailNotifications).HasForeignKey(d => d.CompanyQuestionnaireId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbEmailNotifications).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<TbEmployee>(entity =>
        {
            entity.HasIndex(e => e.AssignedCompanyQuestionnaireId, "IX_TbEmployees_AssignedCompanyQuestionnaireId");

            entity.HasIndex(e => e.MyCompanyId, "IX_TbEmployees_myCompanyId");

            entity.HasIndex(e => e.MyFacilityId, "IX_TbEmployees_myFacilityId");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.EmployeesOtherInformationJson).HasColumnName("EmployeesOtherInformationJSON");
            entity.Property(e => e.InitialVerificationOfVaccineCertificateDone)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsVisitable)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.LastDateTimeModified).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.MyCompanyId).HasColumnName("myCompanyId");
            entity.Property(e => e.MyFacilityId).HasColumnName("myFacilityId");
            entity.Property(e => e.SendAlertForVaccineCertificateSubmission)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.StrongInitialVerificationOfVaccineCertificateDone)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VaccineCertificateVerified)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.AssignedCompanyQuestionnaire).WithMany(p => p.TbEmployees).HasForeignKey(d => d.AssignedCompanyQuestionnaireId);

            entity.HasOne(d => d.MyCompany).WithMany(p => p.TbEmployees).HasForeignKey(d => d.MyCompanyId);

            entity.HasOne(d => d.MyFacility).WithMany(p => p.TbEmployees).HasForeignKey(d => d.MyFacilityId);
        });

        modelBuilder.Entity<TbFacility>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbFacilities_CompanyId");

            entity.HasIndex(e => e.FacilityTypeId, "IX_TbFacilities_FacilityTypeId");

            entity.Property(e => e.AskQuestionForVaccination)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.EmployeesOtherInformationJson).HasColumnName("EmployeesOtherInformationJSON");
            entity.Property(e => e.MinutesDifferenceToUtc).HasColumnName("MinutesDifferenceToUTC");
            entity.Property(e => e.SendAlertEmailToHostOnVisitorCheckIn)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VaccineCertificateVerificationPackage)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VaccineProofNeededToLetPeopleIn)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VerifyEmployeeId)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VisitorPackage)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Company).WithMany(p => p.TbFacilities).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.FacilityType).WithMany(p => p.TbFacilities).HasForeignKey(d => d.FacilityTypeId);
        });

        modelBuilder.Entity<TbFacilityTenant>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbFacilityTenants_FacilityId");

            entity.HasIndex(e => e.TenantFacilityId, "IX_TbFacilityTenants_TenantFacilityId");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbFacilityTenantFacilities).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.TenantFacility).WithMany(p => p.TbFacilityTenantTenantFacilities).HasForeignKey(d => d.TenantFacilityId);
        });

        modelBuilder.Entity<TbFacilityTypeParameter>(entity =>
        {
            entity.HasIndex(e => e.FacilityTypeId, "IX_TbFacilityTypeParameters_FacilityTypeId");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.TbFacilityTypeParameters).HasForeignKey(d => d.FacilityTypeId);
        });

        modelBuilder.Entity<TbMenu>(entity =>
        {
            entity.HasIndex(e => e.MenusId, "IX_TbMenus_MenusId");

            entity.HasIndex(e => e.ParentId, "IX_TbMenus_ParentId");

            entity.Property(e => e.ControllerName).HasMaxLength(256);
            entity.Property(e => e.CssClass).HasMaxLength(256);
            entity.Property(e => e.IsParent)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.NormalizedTitle).HasMaxLength(256);
            entity.Property(e => e.PrimaryAction).HasMaxLength(256);
            entity.Property(e => e.Route).HasMaxLength(256);
            entity.Property(e => e.Title).HasMaxLength(256);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);

            entity.HasMany(d => d.Roles).WithMany(p => p.Menus)
                .UsingEntity<Dictionary<string, object>>(
                    "TbMenuRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TbMenuRoles_AspNetRoles"),
                    l => l.HasOne<TbMenu>().WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("MenuId", "RoleId");
                    });
        });

        modelBuilder.Entity<TbOccupancy>(entity =>
        {
            entity.HasIndex(e => e.AreaId, "IX_TbOccupancies_AreaId");

            entity.HasOne(d => d.Area).WithMany(p => p.TbOccupancies).HasForeignKey(d => d.AreaId);
        });

        modelBuilder.Entity<TbOperationTask>(entity =>
        {
            entity.HasIndex(e => e.Status, "IX_STATUS");

            entity.HasIndex(e => e.ChecklistId, "IX_TbOperationTasks_ChecklistId");

            entity.HasIndex(e => e.FacilityId, "IX_TbOperationTasks_FacilityId");

            entity.HasIndex(e => e.PackageId, "IX_TbOperationTasks_PackageId");

            entity.HasIndex(e => e.UserId, "IX_TbOperationTasks_UserId");

            entity.HasOne(d => d.Checklist).WithMany(p => p.TbOperationTasks).HasForeignKey(d => d.ChecklistId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbOperationTasks).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.Package).WithMany(p => p.TbOperationTasks).HasForeignKey(d => d.PackageId);

            entity.HasOne(d => d.User).WithMany(p => p.TbOperationTasks).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbPackage>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbPackages_FacilityId");

            entity.HasIndex(e => e.PackageTypeId, "IX_TbPackages_PackageTypeId");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbPackages).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.PackageType).WithMany(p => p.TbPackages).HasForeignKey(d => d.PackageTypeId);
        });

        modelBuilder.Entity<TbPackageAction>(entity =>
        {
            entity.ToTable("TbPackage_Actions");

            entity.HasIndex(e => e.PackageId, "IX_TbPackage_Actions_PackageId");

            entity.HasIndex(e => e.PackageActionTypeId, "IX_TbPackage_Actions_Package_Action_TypeId");

            entity.Property(e => e.PackageActionTypeId).HasColumnName("Package_Action_TypeId");
            entity.Property(e => e.UserAssignee).HasColumnName("User_Assignee");
            entity.Property(e => e.UserCreator).HasColumnName("User_Creator");
            entity.Property(e => e.UserOperator).HasColumnName("User_Operator");

            entity.HasOne(d => d.PackageActionType).WithMany(p => p.TbPackageActions).HasForeignKey(d => d.PackageActionTypeId);

            entity.HasOne(d => d.Package).WithMany(p => p.TbPackageActions).HasForeignKey(d => d.PackageId);
        });

        modelBuilder.Entity<TbPackageActionType>(entity =>
        {
            entity.ToTable("TbPackage_Action_Types");
        });

        modelBuilder.Entity<TbPackageServiceStation>(entity =>
        {
            entity.ToTable("TbPackage_ServiceStations");

            entity.HasIndex(e => e.PackageId, "IX_TbPackage_ServiceStations_PackageId");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbPackage_ServiceStations_ServiceStationId");

            entity.HasOne(d => d.Package).WithMany(p => p.TbPackageServiceStations).HasForeignKey(d => d.PackageId);

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbPackageServiceStations).HasForeignKey(d => d.ServiceStationId);
        });

        modelBuilder.Entity<TbQuestionnaireEmailReport>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbQuestionnaireEmailReports_FacilityId");

            entity.Property(e => e.ListOfEmailsJson).HasColumnName("ListOfEmailsJSON");
            entity.Property(e => e.ListOfFiledsJson).HasColumnName("ListOfFiledsJSON");
            entity.Property(e => e.ListOfPersonTypesJson).HasColumnName("ListOfPersonTypesJSON");
            entity.Property(e => e.LockedForEmailSendingProcess)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.TimeTimeOfLocking).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbQuestionnaireEmailReports).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<TbQuestionnaireSubmission>(entity =>
        {
            entity.HasIndex(e => new { e.DateTimeCheckIn, e.CompaniesQuestionnaireId }, "IX_SEARCH_QUERY_EMAILREPORT1");

            entity.HasIndex(e => new { e.DateTypeSubmission, e.CompaniesQuestionnaireId }, "IX_SEARCH_QUERY_EMAILREPORT2");

            entity.HasIndex(e => new { e.DateTimeCheckIn, e.VisitorCheckInNotificationSent }, "IX_SEARCH_QUERY_VISITORSCHECKIN");

            entity.HasIndex(e => e.AreaId, "IX_TbQuestionnaireSubmissions_AreaId");

            entity.HasIndex(e => e.CompaniesQuestionnaireId, "IX_TbQuestionnaireSubmissions_CompaniesQuestionnaireId");

            entity.HasIndex(e => e.RequestedVisitingEmployeeId, "IX_TbQuestionnaireSubmissions_RequestedVisitingEmployeeId");

            entity.HasIndex(e => e.VisitingEmployeeId, "IX_TbQuestionnaireSubmissions_VisitingEmployeeId");

            entity.Property(e => e.ActionTakenDateTimeFroVisitor).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.CheckedOut)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.DateTimeCheckIn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.DateTimeCheckOut).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.DateTimeCheckoutNotificationSent).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.VisitorCheckInNotificationSent)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Area).WithMany(p => p.TbQuestionnaireSubmissions).HasForeignKey(d => d.AreaId);

            entity.HasOne(d => d.CompaniesQuestionnaire).WithMany(p => p.TbQuestionnaireSubmissions).HasForeignKey(d => d.CompaniesQuestionnaireId);

            entity.HasOne(d => d.RequestedVisitingEmployee).WithMany(p => p.TbQuestionnaireSubmissionRequestedVisitingEmployees).HasForeignKey(d => d.RequestedVisitingEmployeeId);

            entity.HasOne(d => d.VisitingEmployee).WithMany(p => p.TbQuestionnaireSubmissionVisitingEmployees).HasForeignKey(d => d.VisitingEmployeeId);
        });

        modelBuilder.Entity<TbRemoteActionRequest>(entity =>
        {
            entity.HasIndex(e => e.RemoteActionRequestTypeId, "IX_TbRemoteActionRequests_RemoteActionRequestTypeId");

            entity.HasIndex(e => e.ServiceStationTypeId, "IX_TbRemoteActionRequests_ServiceStationTypeId");

            entity.Property(e => e.LastDateTimeModified).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.RemoteActionRequestType).WithMany(p => p.TbRemoteActionRequests).HasForeignKey(d => d.RemoteActionRequestTypeId);

            entity.HasOne(d => d.ServiceStationType).WithMany(p => p.TbRemoteActionRequests).HasForeignKey(d => d.ServiceStationTypeId);
        });

        modelBuilder.Entity<TbRemoteActionRequestType>(entity =>
        {
            entity.HasIndex(e => e.ServiceStationTypeId, "IX_TbRemoteActionRequestTypes_ServiceStationTypeId");

            entity.HasOne(d => d.ServiceStationType).WithMany(p => p.TbRemoteActionRequestTypes).HasForeignKey(d => d.ServiceStationTypeId);
        });

        modelBuilder.Entity<TbReportSubmissionsRecord>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbReportSubmissionsRecords_FacilityId");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbReportSubmissionsRecords).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<TbServiceStation>(entity =>
        {
            entity.HasKey(e => e.SsId);

            entity.HasIndex(e => e.FacilityId, "IX_TbServiceStations_FacilityId");

            entity.HasIndex(e => e.ServiceStationTypeId, "IX_TbServiceStations_ServiceStationTypeId");

            entity.Property(e => e.SsId).HasColumnName("ssId");
            entity.Property(e => e.LastDateTimeModified).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.LatestUpdateDateTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbServiceStations).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.ServiceStationType).WithMany(p => p.TbServiceStations).HasForeignKey(d => d.ServiceStationTypeId);
        });

        modelBuilder.Entity<TbServiceStationCompanyVisitorProfileMapping>(entity =>
        {
            entity.ToTable("TbServiceStationCompanyVisitorProfileMapping");

            entity.HasIndex(e => e.CompanyVisitorProfileId, "IX_TbServiceStationCompanyVisitorProfileMapping_CompanyVisitorProfileId");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbServiceStationCompanyVisitorProfileMapping_ServiceStationId");

            entity.HasOne(d => d.CompanyVisitorProfile).WithMany(p => p.TbServiceStationCompanyVisitorProfileMappings).HasForeignKey(d => d.CompanyVisitorProfileId);

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbServiceStationCompanyVisitorProfileMappings).HasForeignKey(d => d.ServiceStationId);
        });

        modelBuilder.Entity<TbServiceStationConnection>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TbServiceStationRecord>(entity =>
        {
            entity.HasIndex(e => new { e.ServiceStationRecordTypeId, e.StatusId }, "IX_SEARCH_QUERY_ServiceStationAlert1");

            entity.HasIndex(e => new { e.DateTimeRecorded, e.ServiceStationRecordTypeId, e.StatusId }, "IX_SEARCH_QUERY_ServiceStationAlert2");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbServiceStationRecords_ServiceStationId");

            entity.HasIndex(e => e.StatusId, "IX_TbServiceStationRecords_StatusId");

            entity.Property(e => e.Reported)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("reported");

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbServiceStationRecords).HasForeignKey(d => d.ServiceStationId);

            entity.HasOne(d => d.ServiceStationRecordType).WithMany(p => p.TbServiceStationRecords).HasForeignKey(d => d.ServiceStationRecordTypeId);

            entity.HasOne(d => d.Status).WithMany(p => p.TbServiceStationRecords).HasForeignKey(d => d.StatusId);
        });

        modelBuilder.Entity<TbServiceStationRecordStatus>(entity =>
        {
            entity.ToTable("TbServiceStationRecordStatus");
        });

        modelBuilder.Entity<TbServiceStationTypeParameter>(entity =>
        {
            entity.HasIndex(e => e.ServiceStationTypeId, "IX_TbServiceStationTypeParameters_ServiceStationTypeId");

            entity.HasOne(d => d.ServiceStationType).WithMany(p => p.TbServiceStationTypeParameters).HasForeignKey(d => d.ServiceStationTypeId);
        });

        modelBuilder.Entity<TbSmokeEvent>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbSmokeEvents_FacilityId");

            entity.Property(e => e.AlertEmailSmssent).HasColumnName("AlertEmailSMSSent");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbSmokeEvents).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<TbSwimmingPool>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbSwimmingPools_FacilityId");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbSwimmingPools_ServiceStationId");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbSwimmingPools).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbSwimmingPools).HasForeignKey(d => d.ServiceStationId);
        });

        modelBuilder.Entity<TbSwimmingPoolRecord>(entity =>
        {
            entity.HasIndex(e => e.SwimmingPoolId, "IX_TbSwimmingPoolRecords_SwimmingPoolId");

            entity.HasOne(d => d.SwimmingPool).WithMany(p => p.TbSwimmingPoolRecords).HasForeignKey(d => d.SwimmingPoolId);
        });

        modelBuilder.Entity<TbTermAndConditionAgreement>(entity =>
        {
            entity.HasIndex(e => e.FacilityId, "IX_TbTermAndConditionAgreements_FacilityId");

            entity.HasIndex(e => e.PersonTypeId, "IX_TbTermAndConditionAgreements_PersonTypeId");

            entity.Property(e => e.ShowOnline)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Facility).WithMany(p => p.TbTermAndConditionAgreements).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.PersonType).WithMany(p => p.TbTermAndConditionAgreements).HasForeignKey(d => d.PersonTypeId);
        });

        modelBuilder.Entity<TbUserAccess>(entity =>
        {
            entity.ToTable("TbUserAccess");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbUserAccess_ServiceStationId");

            entity.HasIndex(e => e.UserId, "IX_TbUserAccess_UserId");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbUserAccesses).HasForeignKey(d => d.ServiceStationId);

            entity.HasOne(d => d.User).WithMany(p => p.TbUserAccesses).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbUserAccessToCompanyQuestionnaire>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbUserAccessToCompanyQuestionnaires_CompanyId");

            entity.HasIndex(e => e.UserId, "IX_TbUserAccessToCompanyQuestionnaires_UserId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessAllFacilities)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.AccessAllServiceStations)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Company).WithMany(p => p.TbUserAccessToCompanyQuestionnaires).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.User).WithMany(p => p.TbUserAccessToCompanyQuestionnaires).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbUserLoginDatum>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_TbUserLoginData_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.TbUserLoginData).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<TbVisitorEntry>(entity =>
        {
            entity.HasIndex(e => e.CompanyId, "IX_TbVisitorEntries_CompanyId");

            entity.HasIndex(e => e.CompanyVisitorProfileId, "IX_TbVisitorEntries_CompanyVisitorProfileId");

            entity.HasIndex(e => e.FacilityId, "IX_TbVisitorEntries_FacilityId");

            entity.HasIndex(e => e.PersonTypeId, "IX_TbVisitorEntries_PersonTypeId");

            entity.HasIndex(e => e.ServiceStationId, "IX_TbVisitorEntries_ServiceStationId");

            entity.Property(e => e.AssignedDock).HasMaxLength(255);
            entity.Property(e => e.Carrier).HasMaxLength(255);
            entity.Property(e => e.ChassisNumber).HasMaxLength(255);
            entity.Property(e => e.Customer).HasMaxLength(255);
            entity.Property(e => e.DateTimeSubmitted).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.EntryType).HasDefaultValueSql("(CONVERT([smallint],(0)))");
            entity.Property(e => e.LicenseCountry).HasMaxLength(255);
            entity.Property(e => e.LicenseNumber).HasMaxLength(255);
            entity.Property(e => e.LicenseState).HasMaxLength(255);
            entity.Property(e => e.TruckLicensePlateCountry).HasMaxLength(255);
            entity.Property(e => e.TruckLicensePlateNumber).HasMaxLength(255);
            entity.Property(e => e.TruckLicensePlateState).HasMaxLength(255);

            entity.HasOne(d => d.Company).WithMany(p => p.TbVisitorEntries).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.CompanyVisitorProfile).WithMany(p => p.TbVisitorEntries).HasForeignKey(d => d.CompanyVisitorProfileId);

            entity.HasOne(d => d.Facility).WithMany(p => p.TbVisitorEntries).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.PersonType).WithMany(p => p.TbVisitorEntries).HasForeignKey(d => d.PersonTypeId);

            entity.HasOne(d => d.ServiceStation).WithMany(p => p.TbVisitorEntries).HasForeignKey(d => d.ServiceStationId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
