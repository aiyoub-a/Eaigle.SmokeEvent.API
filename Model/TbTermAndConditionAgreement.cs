using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbTermAndConditionAgreement
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int? FacilityId { get; set; }

    public string? Creator { get; set; }

    public string? LastEditor { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? Language { get; set; }

    public string? AlertMessage { get; set; }

    public string? NormalMessage { get; set; }

    public int? PersonTypeId { get; set; }

    public bool? ShowOnline { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual TbPersonType? PersonType { get; set; }

    public virtual ICollection<TbAssociateTermsAndConditionsToServiceStation> TbAssociateTermsAndConditionsToServiceStations { get; } = new List<TbAssociateTermsAndConditionsToServiceStation>();
}
