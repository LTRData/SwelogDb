using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VatReport3
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }

    public string? Col32 { get; set; }

    public string? Col4 { get; set; }

    public string? Col42 { get; set; }

    public string? Col5 { get; set; }

    public string? Col52 { get; set; }

    public string? Col6 { get; set; }

    public string? Col7 { get; set; }

    public string? Col8 { get; set; }

    public string? Col9 { get; set; }

    public string? Col92 { get; set; }

    public string? Col10 { get; set; }

    public string? Col102 { get; set; }

    public string? Col11 { get; set; }

    public string? Col12 { get; set; }

    public string? Col122 { get; set; }

    public string? Col13 { get; set; }

    public string? Col132 { get; set; }

    public string? Col142 { get; set; }

    public string? Col14 { get; set; }

    public string? Col15 { get; set; }

    public string? Col152 { get; set; }

    public string? Col16 { get; set; }

    public string? Col162 { get; set; }

    public string? Col17 { get; set; }

    public string? Col172 { get; set; }

    public string? Col18 { get; set; }

    public string? Col182 { get; set; }

    public string? Col3VatCode { get; set; }

    public string? Col4VatCode { get; set; }

    public string? Col5VatCode { get; set; }

    public string? Col6VatCode { get; set; }

    public string? Col7VatCode { get; set; }

    public string? Col8VatCode { get; set; }

    public string? Col9VatCode { get; set; }

    public string? Col10VatCode { get; set; }

    public string? Col11VatCode { get; set; }

    public string? Col12VatCode { get; set; }

    public string? Col13VatCode { get; set; }

    public string? Col14VatCode { get; set; }

    public string? Col15VatCode { get; set; }

    public string? Col16VatCode { get; set; }

    public string? Col17VatCode { get; set; }

    public string? Col18VatCode { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
