using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Dwlabel
{
    public string Dwname { get; set; } = null!;

    public string Objectname { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string? Label { get; set; }

    public string? Helptext { get; set; }

    public string? AuditStamp { get; set; }
}
