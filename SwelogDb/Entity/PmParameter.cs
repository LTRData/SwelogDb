using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmParameter
{
    public int IdPmParameter { get; set; }

    public string? SpecificationPath { get; set; }

    public string? DefaultItemNumber { get; set; }

    public string? AuditStamp { get; set; }
}
