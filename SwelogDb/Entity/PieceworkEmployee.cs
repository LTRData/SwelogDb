using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PieceworkEmployee
{
    public int EmploymentNumber { get; set; }

    public int PieceworkNumber { get; set; }

    public int Percentage { get; set; }
}
