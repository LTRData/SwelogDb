﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AccountText
{
    public string CompanyNo { get; set; } = null!;

    public decimal DemandNo { get; set; }

    public string Language { get; set; } = null!;

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Text3 { get; set; }

    public string? Text4 { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual Language LanguageNavigation { get; set; } = null!;
}
