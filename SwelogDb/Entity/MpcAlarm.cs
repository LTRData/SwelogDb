using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcAlarm
{
    public DateTime MpcStartDate { get; set; }

    public DateTime MpcEndDate { get; set; }

    public decimal ErrNumber { get; set; }

    public string? AlarmId { get; set; }

    public string? Description { get; set; }

    public int? EmployeeNumber { get; set; }

    public string? ActivityNo { get; set; }

    public string? ErrType { get; set; }
}
