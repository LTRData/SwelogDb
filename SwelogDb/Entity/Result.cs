using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Result
{
    public string ReportId { get; set; } = null!;

    public string? ReportName { get; set; }

    public string? OptionsAllowed { get; set; }

    public string? AllFieldsVisible { get; set; }

    public short? FormatCode { get; set; }

    public decimal? MaxReprint { get; set; }

    public decimal? Copies { get; set; }

    public string? Template { get; set; }

    public string? AuditStamp { get; set; }

    public int? CedocPrinterNo { get; set; }
}
