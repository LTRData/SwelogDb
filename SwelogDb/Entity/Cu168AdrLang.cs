﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168AdrLang
{
    public int SerialNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? LanguageCode { get; set; }

    public string? Adr { get; set; }
}
