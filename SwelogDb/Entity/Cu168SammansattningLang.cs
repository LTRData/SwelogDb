using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168SammansattningLang
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? LanguageCode { get; set; }

    public string? Sammansattning { get; set; }
}
