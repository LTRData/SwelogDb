using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStrAv3
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public short TransId { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string AccountNoRecv { get; set; } = null!;

    public string? DepartmentNoRecv { get; set; }

    public string? ProductNoRecv { get; set; }

    public string? ProjectNoRecv { get; set; }

    public string? FunctionNoRecv { get; set; }

    public string? ANoRecv { get; set; }

    public string? BNoRecv { get; set; }

    public string? CNoRecv { get; set; }

    public string? DNoRecv { get; set; }

    public string? AuditStamp { get; set; }
}
