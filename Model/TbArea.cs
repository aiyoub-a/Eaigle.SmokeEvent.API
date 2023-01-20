using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbArea
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? FacilityId { get; set; }

    public int? AreaTypeId { get; set; }

    public string? Info { get; set; }

    public string? Creator { get; set; }

    public DateTime LastDateTimeModified { get; set; }

    public string? LastEditor { get; set; }

    public virtual TbAreaType? AreaType { get; set; }

    public virtual TbFacility? Facility { get; set; }

    public virtual ICollection<TbOccupancy> TbOccupancies { get; } = new List<TbOccupancy>();

    public virtual ICollection<TbQuestionnaireSubmission> TbQuestionnaireSubmissions { get; } = new List<TbQuestionnaireSubmission>();
}
