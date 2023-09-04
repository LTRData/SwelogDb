using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SqlstatLog
{
    public int IdSqlstatLog { get; set; }

    public DateTime? SqlstatDatetime { get; set; }

    public string? WorkStation { get; set; }

    public string? SwelogUser { get; set; }

    public string? NtDomain { get; set; }

    public string? NtUsername { get; set; }

    public string? LogText { get; set; }

    public string? FunctionName { get; set; }
}
