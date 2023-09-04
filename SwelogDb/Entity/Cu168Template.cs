using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168Template
{
    public int SerialNumber { get; set; }

    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? EtikettFilePath { get; set; }

    public string? XmlPrinting { get; set; }

    public string? Spooler { get; set; }
}
