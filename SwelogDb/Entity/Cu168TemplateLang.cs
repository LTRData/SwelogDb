﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168TemplateLang
{
    public int SerialNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? LanguageCode { get; set; }

    public string? FilePath { get; set; }
}
