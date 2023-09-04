using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportPrintlog
{
    public int SerialNo { get; set; }

    public string ReportId { get; set; } = null!;

    public DateTime ReportDate { get; set; }

    public DateTime ReportTime { get; set; }

    public string WorkstationId { get; set; } = null!;

    public string PrintSpooler { get; set; } = null!;

    public byte[]? DwData { get; set; }

    public string? SelectionCriteria { get; set; }

    public string? SortCriteria { get; set; }

    public string? AuditStamp { get; set; }

    public string? TemplateName { get; set; }

    public byte[]? Param { get; set; }
}
