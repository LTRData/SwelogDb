using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeLookup
{
    public int EmploymentNo { get; set; }

    public string? EmployeeName { get; set; }

    public string? PersonCatg { get; set; }

    public string? TimeCatg { get; set; }

    public string? ShiftCode { get; set; }

    public byte? OvertimeMarginIn { get; set; }

    public byte? OvertimeMarginOut { get; set; }
}
