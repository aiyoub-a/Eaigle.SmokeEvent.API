using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAssociateTermsAndConditionsToServiceStation
{
    public int Id { get; set; }

    public int? TermAndConditionAgreementId { get; set; }

    public int? ServiceStationId { get; set; }

    public virtual TbServiceStation? ServiceStation { get; set; }

    public virtual TbTermAndConditionAgreement? TermAndConditionAgreement { get; set; }
}
