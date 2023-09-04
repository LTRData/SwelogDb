using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168ParametersLang
{
    public int SerialNumber { get; set; }

    public string? LanguageCode { get; set; }

    public string? DateFormat { get; set; }

    public byte? DecimalSeparator { get; set; }

    public string? SdsLanguageCode { get; set; }
}
