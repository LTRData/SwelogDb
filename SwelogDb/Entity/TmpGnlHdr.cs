using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpGnlHdr
{
    public int RecId { get; set; }

    public string? ReportId { get; set; }

    public string? ReportName { get; set; }

    public string? ReportType { get; set; }

    public string? AccountNo { get; set; }

    public string? WhichKey { get; set; }

    public string? KeyNoFrom { get; set; }

    public string? KeyNoTo { get; set; }

    public short? NoOfColumns { get; set; }

    public string? AuditStamp { get; set; }

    public string? WhichPiKey { get; set; }

    public string? CurrentYear { get; set; }

    public string? LastYear { get; set; }

    public string? YearBeforeLast { get; set; }

    public int? EmploymentNo { get; set; }

    public string? ShiftCode { get; set; }

    public string? WeekOrMonth { get; set; }

    public string? QualityIssueType { get; set; }

    public string? ProdGrpOrCatg { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemType2 { get; set; }

    public string? ResourceNo { get; set; }

    public string? ItemNo { get; set; }

    public string? PpmType { get; set; }

    public string? CustomerId { get; set; }
}
