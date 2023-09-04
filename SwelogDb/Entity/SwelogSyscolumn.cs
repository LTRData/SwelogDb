using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogSyscolumn
{
    public string Tname { get; set; } = null!;

    public string? Cname { get; set; }

    public string Coltype { get; set; } = null!;

    public short? Length { get; set; }

    public int? Syslength { get; set; }

    public int DefaultValue { get; set; }

    public string Creator { get; set; } = null!;

    public string Nulls { get; set; } = null!;

    public string InPrimaryKey { get; set; } = null!;

    public short? Colno { get; set; }

    public string Remarks { get; set; } = null!;
}
