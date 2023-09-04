using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityParameter
{
    public string CompanyId { get; set; } = null!;

    public short? MaxNoOfUsers { get; set; }

    public string? Superuser { get; set; }

    public string? SuperuserPassword { get; set; }

    public string? SysadminGroupName { get; set; }

    public short? SecurityScanTimeInMinute { get; set; }

    public short? SecurityInvalidateCount { get; set; }

    public string? Translator { get; set; }

    public string? TranslatorPassword { get; set; }

    public short? IdleTime { get; set; }

    public bool? RefuseConnection { get; set; }

    public bool? FlashMessage { get; set; }

    public string? MessageText { get; set; }

    public string? MenuUpgradeStatus { get; set; }

    public string? MenuUpgradeByUser { get; set; }

    public string? MaxNoOfUsersEncrypted { get; set; }

    public string? MaxNoOfTerminalsEncrypted { get; set; }

    public string? CustomerId { get; set; }

    public string? MaxNoOfDashboardsEncrypted { get; set; }

    public string? MaxNoOfSwappUsersEncrypted { get; set; }
}
