using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VatReport
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

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

    public string? AuditStamp { get; set; }

    public string? Col10VatCode { get; set; }

    public string? Col11VatCode { get; set; }

    public string? Col12VatCode { get; set; }

    public string? Col30VatCode { get; set; }

    public string? Col31VatCode { get; set; }

    public string? Col32VatCode { get; set; }

    public string? Col48VatCode { get; set; }

    public string? Col50 { get; set; }

    public string? Col60 { get; set; }

    public string? Col61 { get; set; }

    public string? Col62 { get; set; }

    public string? Col60VatCode { get; set; }

    public string? Col61VatCode { get; set; }

    public string? Col62VatCode { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
