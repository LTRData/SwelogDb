using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlTemplateHdrKey
{
    public int RecNo { get; set; }

    public string? GroupCol { get; set; }

    public short? PeriodNoTo { get; set; }

    public string? DepartmentFlag { get; set; }

    public string? ProductFlag { get; set; }

    public string? ProjectFlag { get; set; }

    public string? FunctionFlag { get; set; }

    public string? AFlag { get; set; }

    public string? BFlag { get; set; }

    public string? CFlag { get; set; }

    public string? DFlag { get; set; }

    public string? AuditStamp { get; set; }

    public short? CurrentFinancialYearNo { get; set; }

    public virtual ICollection<PlTemplateDtlKey> PlTemplateDtlKeys { get; } = new List<PlTemplateDtlKey>();
}
