using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbMenu
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string NormalizedTitle { get; set; } = null!;

    public string? Route { get; set; }

    public string CssClass { get; set; } = null!;

    public int? ParentId { get; set; }

    public bool IsActive { get; set; }

    public bool? IsParent { get; set; }

    public int Order { get; set; }

    public string? PrimaryAction { get; set; }

    public string? ControllerName { get; set; }

    public int? MenusId { get; set; }

    public virtual ICollection<TbMenu> InverseParent { get; } = new List<TbMenu>();

    public virtual TbMenu? Parent { get; set; }

    public virtual ICollection<AspNetRole> Roles { get; } = new List<AspNetRole>();
}
