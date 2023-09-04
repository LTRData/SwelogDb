using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Pbcatfmt
{
    public string PbfName { get; set; } = null!;

    public string? PbfFrmt { get; set; }

    public short? PbfType { get; set; }

    public int? PbfCntr { get; set; }
}
