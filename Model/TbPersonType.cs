using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbPersonType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Info { get; set; }

    public string? DisplayName { get; set; }

    public virtual ICollection<TbCompanyPersonTypeName> TbCompanyPersonTypeNames { get; } = new List<TbCompanyPersonTypeName>();

    public virtual ICollection<TbCompanyQuestionnaire> TbCompanyQuestionnaires { get; } = new List<TbCompanyQuestionnaire>();

    public virtual ICollection<TbTermAndConditionAgreement> TbTermAndConditionAgreements { get; } = new List<TbTermAndConditionAgreement>();

    public virtual ICollection<TbVisitorEntry> TbVisitorEntries { get; } = new List<TbVisitorEntry>();
}
