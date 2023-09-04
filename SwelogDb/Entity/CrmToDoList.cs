using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmToDoList
{
    public int SerialNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? Completed { get; set; }

    public string? Notes { get; set; }

    public int? EventSerialNumber { get; set; }
}
