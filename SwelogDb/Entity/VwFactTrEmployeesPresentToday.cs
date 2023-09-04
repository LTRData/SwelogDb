using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactTrEmployeesPresentToday
{
    public int EmploymentNo { get; set; }

    public DateTime? LastInDateTime { get; set; }
}
