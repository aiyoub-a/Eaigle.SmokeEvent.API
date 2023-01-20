using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbVisitorEntry
{
    public int Id { get; set; }

    public string? AssignedDock { get; set; }

    public int? AssociatedEntry { get; set; }

    public string? BobTailNumber { get; set; }

    public string? Carrier { get; set; }

    public string? ChassisNumber { get; set; }

    public string? Code { get; set; }

    public string? Comments { get; set; }

    public int? CompanyId { get; set; }

    public int? CompanyVisitorProfileId { get; set; }

    public string? Customer { get; set; }

    public DateTime? DateTimeCheckedIn { get; set; }

    public DateTime? DateTimeCheckedOut { get; set; }

    public DateTime DateTimeSubmitted { get; set; }

    public string? Email { get; set; }

    public string? EmployeeId { get; set; }

    public short EntryType { get; set; }

    public int? FacilityId { get; set; }

    public string? FirstName { get; set; }

    public string? GovernmentId { get; set; }

    public string? LastName { get; set; }

    public string? LicenseCountry { get; set; }

    public string? LicenseNumber { get; set; }

    public string? LicenseState { get; set; }

    public int? OperatorId { get; set; }

    public string? OtherInformation { get; set; }

    public int? PersonTypeId { get; set; }

    public string? Phone { get; set; }

    public string? PlateNumber { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? SealNumber { get; set; }

    public int? ServiceStationId { get; set; }

    public int? ServiceTimeInSeconds { get; set; }

    public string? Status { get; set; }

    public int? SupervisorId { get; set; }

    public string? Tags { get; set; }

    public int? TrailerLength { get; set; }

    public string? TrailerNumber { get; set; }

    public short? TrailerStatus { get; set; }

    public string? TruckLicensePlateCountry { get; set; }

    public string? TruckLicensePlateNumber { get; set; }

    public string? TruckLicensePlateState { get; set; }

    public short? TruckType { get; set; }

    public string? VisitorCompany { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbCompanyVisitorProfile? CompanyVisitorProfile { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbPersonType? PersonType { get; set; }

    public virtual TbServiceStation? ServiceStation { get; set; }

    public virtual ICollection<TbAvacdocument> TbAvacdocuments { get; } = new List<TbAvacdocument>();
}
