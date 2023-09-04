using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VatReportResult
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public short PeriodNoFrom { get; set; }

    public short PeriodNoTo { get; set; }

    public DateTime? DeclarationDate { get; set; }

    public string? Col05 { get; set; }

    public string? Col06 { get; set; }

    public string? Col07 { get; set; }

    public string? Col08 { get; set; }

    public string? Col10 { get; set; }

    public string? Col11 { get; set; }

    public string? Col12 { get; set; }

    public string? Col20 { get; set; }

    public string? Col21 { get; set; }

    public string? Col22 { get; set; }

    public string? Col23 { get; set; }

    public string? Col24 { get; set; }

    public string? Col30 { get; set; }

    public string? Col31 { get; set; }

    public string? Col32 { get; set; }

    public string? Col35 { get; set; }

    public string? Col36 { get; set; }

    public string? Col37 { get; set; }

    public string? Col38 { get; set; }

    public string? Col39 { get; set; }

    public string? Col40 { get; set; }

    public string? Col41 { get; set; }

    public string? Col42 { get; set; }

    public string? Col48 { get; set; }

    public string? Col49 { get; set; }

    public string? AuditStamp { get; set; }

    public string? GeneratedVouchers { get; set; }

    public string? Col50 { get; set; }

    public string? Col60 { get; set; }

    public string? Col61 { get; set; }

    public string? Col62 { get; set; }
}
