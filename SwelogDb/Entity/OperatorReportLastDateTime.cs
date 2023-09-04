using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorReportLastDateTime
{
    public int EmployeeNumber { get; set; }

    public DateTime? StartDateTime { get; set; }
}
