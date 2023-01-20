using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbCompanyPersonTypeName
{
    public int Id { get; set; }

    public int? PersonTypeId { get; set; }

    public string DisplayName { get; set; } = null!;

    public int? CompanyId { get; set; }

    public virtual TbCompany? Company { get; set; }

    public virtual TbPersonType? PersonType { get; set; }
}
