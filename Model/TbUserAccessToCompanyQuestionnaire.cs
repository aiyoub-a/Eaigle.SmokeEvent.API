using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbUserAccessToCompanyQuestionnaire
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int CompanyId { get; set; }

    public bool AccessSuspended { get; set; }

    public bool? AccessAllFacilities { get; set; }

    public bool? AccessAllServiceStations { get; set; }

    public string? ListOfAccessToFacilitiesJson { get; set; }

    public string? ListOfAccessToServiceStationsJson { get; set; }

    public virtual TbCompany Company { get; set; } = null!;

    public virtual AspNetUser? User { get; set; }
}
