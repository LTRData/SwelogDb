using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168DoseringsEnhetLang
{
    public int SerialNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? LanguageCode { get; set; }

    public string? DoseringsEnhet { get; set; }
}
