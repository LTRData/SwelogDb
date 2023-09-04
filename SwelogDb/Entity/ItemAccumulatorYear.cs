using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemAccumulatorYear
{
    public int SerialNo { get; set; }

    public DateTime? YearStartDatetime { get; set; }

    public DateTime? YearEndDatetime { get; set; }
}
