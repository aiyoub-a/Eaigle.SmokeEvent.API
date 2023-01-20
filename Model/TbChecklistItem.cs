using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbChecklistItem
{
    public int Id { get; set; }

    public int Order { get; set; }

    public string? Text { get; set; }

    public string? Options { get; set; }

    public int? ChecklistId { get; set; }

    public byte[]? DataFile { get; set; }

    public string? FileType { get; set; }

    public virtual TbChecklist? Checklist { get; set; }
}
