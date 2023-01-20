using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbServiceStation
{
    public int? ServiceStationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public bool Active { get; set; }

    public int? FacilityId { get; set; }

    public int SsId { get; set; }

    public string? Code { get; set; }

    public string? Parameters { get; set; }

    public string? Creator { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LatestUpdateDateTime { get; set; }

    public string? SoftwareVersion { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbServiceStationType? ServiceStationType { get; set; }

    public virtual ICollection<TbAssociateTermsAndConditionsToServiceStation> TbAssociateTermsAndConditionsToServiceStations { get; } = new List<TbAssociateTermsAndConditionsToServiceStation>();

    public virtual ICollection<TbAssociationOfServiceStationsAndQuestionnaire> TbAssociationOfServiceStationsAndQuestionnaires { get; } = new List<TbAssociationOfServiceStationsAndQuestionnaire>();

    public virtual ICollection<TbPackageServiceStation> TbPackageServiceStations { get; } = new List<TbPackageServiceStation>();

    public virtual ICollection<TbRemoteActionRequest> TbRemoteActionRequests { get; } = new List<TbRemoteActionRequest>();

    public virtual ICollection<TbServiceStationCompanyVisitorProfileMapping> TbServiceStationCompanyVisitorProfileMappings { get; } = new List<TbServiceStationCompanyVisitorProfileMapping>();

    public virtual ICollection<TbServiceStationRecord> TbServiceStationRecords { get; } = new List<TbServiceStationRecord>();

    public virtual ICollection<TbSwimmingPool> TbSwimmingPools { get; } = new List<TbSwimmingPool>();

    public virtual ICollection<TbUserAccess> TbUserAccesses { get; } = new List<TbUserAccess>();

    public virtual ICollection<TbVisitorEntry> TbVisitorEntries { get; } = new List<TbVisitorEntry>();
}
