using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AccountType
{
    public string CompanyNo { get; set; } = null!;

    public string AccountTypeNo { get; set; } = null!;

    public string? Description { get; set; }

    public decimal AccountGroup { get; set; }

    public string? AccountType1 { get; set; }

    public string? DepartmentAccounting { get; set; }

    public string? ProductAccounting { get; set; }

    public string? ProjectAccounting { get; set; }

    public string? FunctionAccounting { get; set; }

    public string? AAccounting { get; set; }

    public string? BAccounting { get; set; }

    public string? CAccounting { get; set; }

    public string? DAccounting { get; set; }

    public string? NormalSign { get; set; }

    public string? AuditStamp { get; set; }

    public string? DepartmentAccountingM { get; set; }

    public string? ProductAccountingM { get; set; }

    public string? ProjectAccountingM { get; set; }

    public string? FunctionAccountingM { get; set; }

    public string? AAccountingM { get; set; }

    public string? BAccountingM { get; set; }

    public string? CAccountingM { get; set; }

    public string? DAccountingM { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
