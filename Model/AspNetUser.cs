using System;
using System.Collections.Generic;

namespace Eaigle.SmokeEvent.API.Model;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Discriminator { get; set; } = null!;

    public string? Company { get; set; }

    public string? Department { get; set; }

    public string? PositionInCompany { get; set; }

    public string? AccessTools { get; set; }

    public string? AdminUserId { get; set; }

    public bool? UserAccessConfirmed { get; set; }

    public string? DataAccessRules { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; } = new List<AspNetUserToken>();

    public virtual ICollection<TbActionLog> TbActionLogs { get; } = new List<TbActionLog>();

    public virtual ICollection<TbOperationTask> TbOperationTasks { get; } = new List<TbOperationTask>();

    public virtual ICollection<TbUserAccessToCompanyQuestionnaire> TbUserAccessToCompanyQuestionnaires { get; } = new List<TbUserAccessToCompanyQuestionnaire>();

    public virtual ICollection<TbUserAccess> TbUserAccesses { get; } = new List<TbUserAccess>();

    public virtual ICollection<TbUserLoginDatum> TbUserLoginData { get; } = new List<TbUserLoginDatum>();

    public virtual ICollection<AspNetRole> Roles { get; } = new List<AspNetRole>();
}
