using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class TbAssociationOfServiceStationsAndQuestionnaire
{
    public int Id { get; set; }

    public int ServiceStationId { get; set; }

    public int QuestionnaireId { get; set; }

    public bool AccessSuspended { get; set; }

    public virtual TbCompanyQuestionnaire Questionnaire { get; set; } = null!;

    public virtual TbServiceStation ServiceStation { get; set; } = null!;
}
