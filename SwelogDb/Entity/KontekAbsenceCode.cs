using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KontekAbsenceCode
{
    public string AbsenceCode { get; set; } = null!;

    public string? AbsenceCodeDescription { get; set; }
}
