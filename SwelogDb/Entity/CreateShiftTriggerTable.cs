using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CreateShiftTriggerTable
{
    public int EmploymentNo { get; set; }

    public DateTime? ShiftDate { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? ShiftStart { get; set; }
}
