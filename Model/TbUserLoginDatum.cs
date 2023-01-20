using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbUserLoginDatum
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime LoginDateTime { get; set; }

    public string? TypeOfLogin { get; set; }

    public virtual AspNetUser? User { get; set; }
}
