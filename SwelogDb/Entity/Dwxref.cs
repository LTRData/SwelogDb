using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Dwxref
{
    public string Classname { get; set; } = null!;

    public string Dwname { get; set; } = null!;

    public string? Dwtext { get; set; }

    public string? Dwtypflag { get; set; }

    public decimal? Dworder { get; set; }

    public string? Dwstatus { get; set; }

    public string? Keycolumns { get; set; }

    public string? Searchcolumns { get; set; }

    public string? Userobject { get; set; }

    public string? AuditStamp { get; set; }
}
