using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbSmokeEvent
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public DateTime DateTimeStart { get; set; }

    public DateTime DateTimeStop { get; set; }

    public string? Description { get; set; }

    public int TakenByProcessId { get; set; }

    public bool AlertEmailSmssent { get; set; }

    public virtual TbFacility? Facility { get; set; }
}
