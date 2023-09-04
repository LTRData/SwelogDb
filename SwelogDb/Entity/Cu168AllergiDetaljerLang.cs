using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168AllergiDetaljerLang
{
    public int SerialNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? LanguageCode { get; set; }

    public string? AllergiDetaljerBeskrivning { get; set; }
}
