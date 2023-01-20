using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAvacdocument
{
    public int Id { get; set; }

    public byte[]? Data { get; set; }

    public string? Path { get; set; }

    public bool IsActive { get; set; }

    public string? Format { get; set; }

    public int VisitorEntryId { get; set; }

    public int? AvacdocumentTypeId { get; set; }

    public virtual TbAvacdocumentType? AvacdocumentType { get; set; }

    public virtual TbVisitorEntry VisitorEntry { get; set; } = null!;
}
