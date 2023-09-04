﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VatReport2
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }

    public string? Col4 { get; set; }

    public string? Col42 { get; set; }

    public string? Col5 { get; set; }

    public string? Col52 { get; set; }

    public string? Col6 { get; set; }

    public string? Col62 { get; set; }

    public string? Col7 { get; set; }

    public string? Col72 { get; set; }

    public string? Col8 { get; set; }

    public string? Col9 { get; set; }

    public string? Col10 { get; set; }

    public string? Col42VatCode { get; set; }

    public string? Col52VatCode { get; set; }

    public string? Col62VatCode { get; set; }

    public string? Col72VatCode { get; set; }

    public string? Col8VatCode { get; set; }

    public string? Col9VatCode { get; set; }

    public string? Col10VatCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? Col81 { get; set; }

    public string? Col91 { get; set; }

    public string? Col101 { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
