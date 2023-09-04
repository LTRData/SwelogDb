using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsentryReport
{
    public int IdGoodsentryReport { get; set; }

    public DateTime? ArrivalDateDatetime { get; set; }

    public int? ReportBatch { get; set; }

    public DateTime? ProcessDatetime { get; set; }
}
