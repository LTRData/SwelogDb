using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu16ItemFile
{
    public int IdCu16ItemFile { get; set; }

    public int? ProcessId { get; set; }

    public string? PopId { get; set; }

    public string? Komponent { get; set; }

    public string? Obj { get; set; }

    public string? Artikel { get; set; }

    public string? Antal { get; set; }
}
