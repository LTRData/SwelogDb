using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcUpdationHistory
{
    public DateTime MpcStartDate { get; set; }

    public DateTime MpcEndDate { get; set; }

    public DateTime? MpcUpdationDate { get; set; }

    public bool? Cu97 { get; set; }

    public int? Cu97AtSelection { get; set; }
}
