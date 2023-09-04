using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmReportsCustomisation
{
    public int SerialNumber { get; set; }

    public int InternalSerialNumber { get; set; }

    public int CustomisationId { get; set; }

    public string? ReportName { get; set; }
}
