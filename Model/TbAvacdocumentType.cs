using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAvacdocumentType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TbAvacdocument> TbAvacdocuments { get; } = new List<TbAvacdocument>();
}
